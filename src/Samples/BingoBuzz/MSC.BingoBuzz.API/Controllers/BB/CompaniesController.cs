// <auto-generated> - Template:WebApiController, Version:1.0, Id:4b60314b-c212-46e3-8945-3d5daecee905
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Routing;
using Marvin.JsonPatch;
using cghEnums = CodeGenHero.Repository.Enums;
using CodeGenHero.DataService;
using CodeGenHero.Logging;
using CodeGenHero.Repository.AutoMapper;
using CodeGenHero.WebApi;
using CodeGenHero.BingoBuzz.Repository.Interface;
using dtoBB = CodeGenHero.BingoBuzz.DTO.BB;
using entBB = CodeGenHero.BingoBuzz.Repository.Entities.BB;

namespace CodeGenHero.BingoBuzz.API.Controllers.BB
{
public partial class CompaniesBBController : BBBaseApiController
{
	private const string GET_LIST_ROUTE_NAME = "CompaniesBBList";
	private const int maxPageSize = 100;

	private GenericFactory<entBB.Company, dtoBB.Company> _factory 
	= new GenericFactory<entBB.Company, dtoBB.Company>();

		public CompaniesBBController() : base()
		{
		}

		public CompaniesBBController(ILoggingService log, IBBRepository repository)
		: base(log, repository)
		{
		}

		[HttpDelete]
		[VersionedRoute(template: "Companies/{companyId}", allowedVersion: 1)]
		public async Task<IHttpActionResult> Delete(System.Guid companyId)
		{
			try
			{
				base.OnActionExecuting();

				var result = Repo.DeleteCompany(companyId);

				if (result.Status == cghEnums.RepositoryActionStatus.Deleted)
				{
					return StatusCode(HttpStatusCode.NoContent);
				}
				else if (result.Status == cghEnums.RepositoryActionStatus.NotFound)
				{
					return NotFound();
				}

				Warn("Unable to delete object via Web API", LogMessageType.Instance.Warn_WebApi, result.Exception, httpResponseStatusCode: 400, url: Request.RequestUri.ToString());
				return BadRequest();
			}
			catch (Exception ex)
			{
				Error(message: ex.Message, logMessageType: LogMessageType.Instance.Exception_WebApi, ex: ex);

				if (System.Diagnostics.Debugger.IsAttached)
				System.Diagnostics.Debugger.Break();

				return InternalServerError();
			}
		}

		[HttpGet]
		[VersionedRoute(template: "Companies", allowedVersion: 1, Name = GET_LIST_ROUTE_NAME)]
		public async Task<IHttpActionResult> Get(string sort = null,
		string fields = null, string filter = null, int page = 1, int pageSize = maxPageSize)
		{
			try
			{
				base.OnActionExecuting();

				var fieldList = GetListByDelimiter(fields);
				bool childrenRequested = false; // TODO: set this based upon actual fields requested.

				var filterList = GetListByDelimiter(filter);
				var dbItems = Repo.GetQueryableCompany().AsNoTracking();
				RunCustomLogicAfterGetQueryableList(ref dbItems, ref filterList);
				dbItems = dbItems.ApplyFilter(filterList);
				dbItems = dbItems.ApplySort(sort ?? (typeof(entBB.Company).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance)).First().Name);

				if (pageSize > maxPageSize)
				{ // ensure the page size isn't larger than the maximum.
					pageSize = maxPageSize;
				}

				var urlHelper = new UrlHelper(Request);
				PageData paginationHeader = BuildPaginationHeader(urlHelper, GET_LIST_ROUTE_NAME, page: page, totalCount: dbItems.Count(), pageSize: pageSize, sort: sort);
				HttpContext.Current.Response.Headers.Add("X-Pagination", Newtonsoft.Json.JsonConvert.SerializeObject(paginationHeader));

				// return result
				return Ok(dbItems
				.Skip(pageSize * (page - 1))
				.Take(pageSize)
				.ToList()
				.Select(x => _factory.CreateDataShapedObject(x, fieldList, childrenRequested)));
			}
			catch (Exception ex)
			{
				Error(message: ex.Message, logMessageType: LogMessageType.Instance.Exception_WebApi, ex: ex);

				if (System.Diagnostics.Debugger.IsAttached)
				System.Diagnostics.Debugger.Break();

				return InternalServerError();
			}
		}

		[HttpGet]
		[VersionedRoute(template: "Companies/{companyId}", allowedVersion: 1)]
		public async Task<IHttpActionResult> Get(System.Guid companyId, int numChildLevels = 0)
		{
			try
			{
				base.OnActionExecuting();

				var qryItem = Repo.GetQueryableCompany().AsNoTracking();
				RunCustomLogicOnGetQueryableByPK(ref qryItem, companyId, numChildLevels);

				var dbItem = qryItem.Where(x => x.CompanyId == companyId).FirstOrDefault();

				if (dbItem == null)
				{
					Warn("Unable to get object via Web API", LogMessageType.Instance.Warn_WebApi, httpResponseStatusCode: 404, url: Request.RequestUri.ToString());
					return NotFound();
				}

				RunCustomLogicOnGetEntityByPK(ref dbItem, companyId, numChildLevels);
				return Ok(_factory.Create(dbItem));
			}
			catch (Exception ex)
			{
				Error(message: ex.Message, logMessageType: LogMessageType.Instance.Exception_WebApi, ex: ex);

				if (System.Diagnostics.Debugger.IsAttached)
				System.Diagnostics.Debugger.Break();

				return InternalServerError();
			}
		}

		[HttpPatch]
		[VersionedRoute(template: "Companies/{companyId}", allowedVersion: 1)]
		public async Task<IHttpActionResult> Patch(System.Guid companyId, [FromBody] JsonPatchDocument<dtoBB.Company> patchDocument)
		{
			try
			{
				base.OnActionExecuting();

				if (patchDocument == null)
				{
					return BadRequest();
				}

				var dbItem = Repo.GetCompany(companyId);
				if (dbItem == null)
				{
					return NotFound();
				}

				var dtoItem = _factory.Create(dbItem); // map

				// apply changes to the DTO
				patchDocument.ApplyTo(dtoItem);
				dtoItem.CompanyId = companyId;

				// map the DTO with applied changes to the entity, & update
				var updatedDBItem = _factory.Create(dtoItem); // map
				var result = Repo.Update(updatedDBItem);

				if (result.Status == cghEnums.RepositoryActionStatus.Updated)
				{
					// map to dto
					var patchedDTOItem = _factory.Create(result.Entity);
					return Ok(patchedDTOItem);
				}

				Warn("Unable to patch object via Web API", LogMessageType.Instance.Warn_WebApi, result.Exception, httpResponseStatusCode: 400, url: Request.RequestUri.ToString());
				return BadRequest();
			}
			catch (Exception ex)
			{
				Error(message: ex.Message, logMessageType: LogMessageType.Instance.Exception_WebApi, ex: ex);

				if (System.Diagnostics.Debugger.IsAttached)
				System.Diagnostics.Debugger.Break();

				return InternalServerError();
			}
		}

		[HttpPost]
		[VersionedRoute(template: "Companies", allowedVersion: 1)]
		public async Task<IHttpActionResult> Post([FromBody] dtoBB.Company dtoItem)
		{
			try
			{
				base.OnActionExecuting();

				if (dtoItem == null)
				{
					return BadRequest();
				}

				// try mapping & saving
				var newDBItem = _factory.Create(dtoItem);

				var result = Repo.Insert(newDBItem);
				if (result.Status == cghEnums.RepositoryActionStatus.Created)
				{   // map to dto
					RunCustomLogicAfterInsert(newDBItem);

					var newDTOItem = _factory.Create(result.Entity);
					var uriFormatted = Request.RequestUri.ToString().EndsWith("/") == true ? Request.RequestUri.ToString().Substring(0, Request.RequestUri.ToString().Length - 1) : Request.RequestUri.ToString();
					return Created($"{uriFormatted}/{newDTOItem.CompanyId}", newDTOItem);
				}

				Warn("Unable to create object via Web API", LogMessageType.Instance.Warn_WebApi, result.Exception, httpResponseStatusCode: 400, url: Request.RequestUri.ToString());
				return BadRequest();
			}
			catch (Exception ex)
			{
				Error(message: ex.Message, logMessageType: LogMessageType.Instance.Exception_WebApi, ex: ex);

				if (System.Diagnostics.Debugger.IsAttached)
				System.Diagnostics.Debugger.Break();

				return InternalServerError();
			}
		}

		[HttpPut]
		[VersionedRoute(template: "Companies/{companyId}", allowedVersion: 1)]
		public async Task<IHttpActionResult> Put(System.Guid companyId, [FromBody] dtoBB.Company dtoItem)
		{
			try
			{
				base.OnActionExecuting();

				if (dtoItem == null)
				{
					return BadRequest();
				}

				dtoItem.CompanyId = companyId;

				var updatedDBItem = _factory.Create(dtoItem); // map
				var result = Repo.Update(updatedDBItem);

				if (result.Status == cghEnums.RepositoryActionStatus.Updated)
				{
					// map to dto
					var updatedDTOItem = _factory.Create(result.Entity);
					return Ok(updatedDTOItem);
				}
				else if (result.Status == cghEnums.RepositoryActionStatus.NotFound)
				{
					return NotFound();
				}

				Warn("Unable to update object via Web API", LogMessageType.Instance.Warn_WebApi, result.Exception, httpResponseStatusCode: 400, url: Request.RequestUri.ToString());
				return BadRequest();
			}
			catch (Exception ex)
			{
				Error(message: ex.Message, logMessageType: LogMessageType.Instance.Exception_WebApi, ex: ex);

				if (System.Diagnostics.Debugger.IsAttached)
				System.Diagnostics.Debugger.Break();

				return InternalServerError();
			}
		}

		partial void RunCustomLogicAfterInsert(entBB.Company newDBItem);

		partial void RunCustomLogicOnGetQueryableByPK(ref IQueryable<entBB.Company> qryItem, System.Guid companyId, int numChildLevels);

		/// <summary>
		/// A sample implementation of custom logic used to include related entities to return with a DTO.
		/// </summary>
		/// <param name="qryItem"></param>
		/// <param name="id"></param>
		/// <param name="numChildLevels"></param>
		// partial void RunCustomLogicOnGetQueryableByPK(ref IQueryable<entBB.Company> qryItem, System.Guid companyId, int numChildLevels)
		// {
			// if (numChildLevels > 0)
			// {
				// qryItem = qryItem.Include(x => x.RelatedParentEntity)
					// .Include(x => x.RelatedChildEntities);
			// }

		// }

		partial void RunCustomLogicOnGetEntityByPK(ref entBB.Company dbItem, System.Guid companyId, int numChildLevels);

		/// <summary>
		/// A sample implementation of custom logic used to either manipulate a DTO item or include related entities.
		/// </summary>
		/// <param name="dbItem"></param>
		/// <param name="id"></param>
		/// <param name="numChildLevels"></param>
		// partial void RunCustomLogicOnGetEntityByPK(ref entBB.Company dbItem, System.Guid companyId, int numChildLevels)
		// {
			// if (numChildLevels > 1)
			// {
				// int[] orderLineItemIds = dbItem.OrderLineItems.Select(x => x.OrderLineItemId).ToArray();

				// var lineItemDiscounts = Repo.BBDataContext.OrderLineItemDiscounts.Where(x => orderLineItemIds.Contains(x.OrderLineItemId)).ToList();

				// foreach (var lineItemDiscount in lineItemDiscounts)
				// { // Find the match and add the item to it.
					// var orderLineItem = dbItem.OrderLineItems.Where(x => x.OrderLineItemId == lineItemDiscount.OrderLineItemId).FirstOrDefault();

					// if (orderLineItem == null)
					// {
						// throw new System.Data.Entity.Core.ObjectNotFoundException($"Unable to locate matching OrderLineItem record for {lineItemDiscount.OrderLineItemId}."
					// }

					// orderLineItem.LineItemDiscounts.Add(lineItemDiscount);
				// }
			// }

		// }

		partial void RunCustomLogicAfterGetQueryableList(ref IQueryable<entBB.Company> dbItems, ref List<string> filterList);

		/// <summary>
		/// A sample implementation of custom logic used to filter on a field that exists in a related, parent, table.
		/// </summary>
		/// <param name="dbItems"></param>
		/// <param name="filterList"></param>
		//partial void RunCustomLogicAfterGetQueryableList(ref IQueryable<entBB.Company> dbItems, ref List<string> filterList)
		//{
		//	var queryableFilters = filterList.ToQueryableFilter();
		//	var myFilterCriterion = queryableFilters.Where(y => y.Member.ToLowerInvariant() == "<myFieldName>").FirstOrDefault(); // Examine the incoming filter for the presence of a field name which does not exist on the target entity.

		//	if (myFilterCriterion != null)
		//	{   // myFieldName is a criterion that has to be evaluated at a level other than our target entity.
		//		dbItems = dbItems.Include(x => x.myFKRelatedEntity).Where(x => x.myFKRelatedEntity.myFieldName == new Guid(myFilterCriterion.Value));
		//		queryableFilters.Remove(myFilterCriterion);  // The evaluated criterion needs to be removed from the list of filters before we invoke the ApplyFilter() extension method.
		//		filterList = queryableFilters.ToQueryableStringList();
		//	}
		//}
	}
}
