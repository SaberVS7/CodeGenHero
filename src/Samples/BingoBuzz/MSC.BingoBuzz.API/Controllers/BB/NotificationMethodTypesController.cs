// <auto-generated>
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
using MSC.BingoBuzz.Repository.Interface;
using CodeGenHero.EAMVCXamPOCO.Repository.Factories;
using dtoBB = MSC.BingoBuzz.DTO.BB;
using entBB = MSC.BingoBuzz.Repository.Entities.BB;
using appEnums = CodeGenHero.EAMVCXamPOCO.Enums;
using CodeGenHero.EAMVCXamPOCO.Interface;
using CodeGenHero.EAMVCXamPOCO.API.Helpers;
using CodeGenHero.EAMVCXamPOCO;

namespace MSC.BingoBuzz.API.Controllers.BB
{
public partial class NotificationMethodTypesBBController : BBBaseApiController
{
	private const string GET_LIST_ROUTE_NAME = "NotificationMethodTypesBBList";
	private const int maxPageSize = 100;

	private GenericFactory<entBB.NotificationMethodType, dtoBB.NotificationMethodType> _factory 
	= new GenericFactory<entBB.NotificationMethodType, dtoBB.NotificationMethodType>();

		public NotificationMethodTypesBBController() : base()
		{
		}

		public NotificationMethodTypesBBController(ILoggingService log, IBBRepository repository)
		: base(log, repository)
		{
		}

		[HttpDelete]
		[VersionedRoute(template: "NotificationMethodTypes/{notificationMethodTypeId}", allowedVersion: 1)]
		public async Task<IHttpActionResult> Delete(int notificationMethodTypeId)
		{
			try
			{
				base.OnActionExecuting();

				var result = Repo.DeleteNotificationMethodType(notificationMethodTypeId);

				if (result.Status == appEnums.RepositoryActionStatus.Deleted)
				{
					return StatusCode(HttpStatusCode.NoContent);
				}
				else if (result.Status == appEnums.RepositoryActionStatus.NotFound)
				{
					return NotFound();
				}

				Warn("Unable to delete object via Web API", appEnums.LogMessageType.Warn_WebApi, result.Exception, httpResponseStatusCode: 400, url: Request.RequestUri.ToString());
				return BadRequest();
			}
			catch (Exception ex)
			{
				Error(message: ex.Message, logMessageType: appEnums.LogMessageType.Exception_WebApi, ex: ex);

				if (System.Diagnostics.Debugger.IsAttached)
				System.Diagnostics.Debugger.Break();

				return InternalServerError();
			}
		}

		[HttpGet]
		[VersionedRoute(template: "NotificationMethodTypes", allowedVersion: 1, Name = GET_LIST_ROUTE_NAME)]
		public async Task<IHttpActionResult> Get(string sort = null,
		string fields = null, string filter = null, int page = 1, int pageSize = maxPageSize)
		{
			try
			{
				base.OnActionExecuting();

				var fieldList = GetListByDelimiter(fields);
				bool childrenRequested = false; // TODO: set this based upon actual fields requested.

				var filterList = GetListByDelimiter(filter);
				var dbItems = Repo.GetQueryableNotificationMethodType();
				RunCustomLogicAfterGetQueryableList(ref dbItems, ref filterList);
				dbItems = dbItems.ApplyFilter(filterList);
				dbItems = dbItems.ApplySort(sort ?? (typeof(entBB.NotificationMethodType).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance)).First().Name);

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
				Error(message: ex.Message, logMessageType: appEnums.LogMessageType.Exception_WebApi, ex: ex);

				if (System.Diagnostics.Debugger.IsAttached)
				System.Diagnostics.Debugger.Break();

				return InternalServerError();
			}
		}

		[HttpGet]
		[VersionedRoute(template: "NotificationMethodTypes/{notificationMethodTypeId}", allowedVersion: 1)]
		public async Task<IHttpActionResult> Get(int notificationMethodTypeId)
		{
			try
			{
				base.OnActionExecuting();

				var qryItem = Repo.GetQueryableNotificationMethodType();
				RunCustomLogicAfterGetQueryableByPK(ref qryItem, notificationMethodTypeId);

				var dbItem = qryItem.Where(x => x.NotificationMethodTypeId == notificationMethodTypeId).FirstOrDefault();

				if (dbItem == null)
				{
					Warn("Unable to get object via Web API", appEnums.LogMessageType.Warn_WebApi, httpResponseStatusCode: 404, url: Request.RequestUri.ToString());
					return NotFound();
				}

				return Ok(_factory.Create(dbItem));
			}
			catch (Exception ex)
			{
				Error(message: ex.Message, logMessageType: appEnums.LogMessageType.Exception_WebApi, ex: ex);

				if (System.Diagnostics.Debugger.IsAttached)
				System.Diagnostics.Debugger.Break();

				return InternalServerError();
			}
		}

		[HttpPatch]
		[VersionedRoute(template: "NotificationMethodTypes/{notificationMethodTypeId}", allowedVersion: 1)]
		public async Task<IHttpActionResult> Patch(int notificationMethodTypeId, [FromBody] JsonPatchDocument<dtoBB.NotificationMethodType> patchDocument)
		{
			try
			{
				base.OnActionExecuting();

				if (patchDocument == null)
				{
					return BadRequest();
				}

				var dbItem = Repo.GetNotificationMethodType(notificationMethodTypeId);
				if (dbItem == null)
				{
					return NotFound();
				}

				var dtoItem = _factory.Create(dbItem); // map

				// apply changes to the DTO
				patchDocument.ApplyTo(dtoItem);
				dtoItem.NotificationMethodTypeId = notificationMethodTypeId;

				// map the DTO with applied changes to the entity, & update
				var updatedDBItem = _factory.Create(dtoItem); // map
				var result = Repo.Update(updatedDBItem);

				if (result.Status == appEnums.RepositoryActionStatus.Updated)
				{
					// map to dto
					var patchedDTOItem = _factory.Create(result.Entity);
					return Ok(patchedDTOItem);
				}

				Warn("Unable to patch object via Web API", appEnums.LogMessageType.Warn_WebApi, result.Exception, httpResponseStatusCode: 400, url: Request.RequestUri.ToString());
				return BadRequest();
			}
			catch (Exception ex)
			{
				Error(message: ex.Message, logMessageType: appEnums.LogMessageType.Exception_WebApi, ex: ex);

				if (System.Diagnostics.Debugger.IsAttached)
				System.Diagnostics.Debugger.Break();

				return InternalServerError();
			}
		}

		[HttpPost]
		[VersionedRoute(template: "NotificationMethodTypes", allowedVersion: 1)]
		public async Task<IHttpActionResult> Post([FromBody] dtoBB.NotificationMethodType dtoItem)
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
				if (result.Status == appEnums.RepositoryActionStatus.Created)
				{   // map to dto
					RunCustomLogicAfterInsert(newDBItem);

					var newDTOItem = _factory.Create(result.Entity);
					var uriFormatted = Request.RequestUri.ToString().EndsWith("/") == true ? Request.RequestUri.ToString().Substring(0, Request.RequestUri.ToString().Length - 1) : Request.RequestUri.ToString();
					return Created($"{uriFormatted}/{newDTOItem.NotificationMethodTypeId}", newDTOItem);
				}

				Warn("Unable to create object via Web API", appEnums.LogMessageType.Warn_WebApi, result.Exception, httpResponseStatusCode: 400, url: Request.RequestUri.ToString());
				return BadRequest();
			}
			catch (Exception ex)
			{
				Error(message: ex.Message, logMessageType: appEnums.LogMessageType.Exception_WebApi, ex: ex);

				if (System.Diagnostics.Debugger.IsAttached)
				System.Diagnostics.Debugger.Break();

				return InternalServerError();
			}
		}

		[HttpPut]
		[VersionedRoute(template: "NotificationMethodTypes/{notificationMethodTypeId}", allowedVersion: 1)]
		public async Task<IHttpActionResult> Put(int notificationMethodTypeId, [FromBody] dtoBB.NotificationMethodType dtoItem)
		{
			try
			{
				base.OnActionExecuting();

				if (dtoItem == null)
				{
					return BadRequest();
				}

				dtoItem.NotificationMethodTypeId = notificationMethodTypeId;

				var updatedDBItem = _factory.Create(dtoItem); // map
				var result = Repo.Update(updatedDBItem);

				if (result.Status == appEnums.RepositoryActionStatus.Updated)
				{
					// map to dto
					var updatedDTOItem = _factory.Create(result.Entity);
					return Ok(updatedDTOItem);
				}
				else if (result.Status == appEnums.RepositoryActionStatus.NotFound)
				{
					return NotFound();
				}

				Warn("Unable to update object via Web API", appEnums.LogMessageType.Warn_WebApi, result.Exception, httpResponseStatusCode: 400, url: Request.RequestUri.ToString());
				return BadRequest();
			}
			catch (Exception ex)
			{
				Error(message: ex.Message, logMessageType: appEnums.LogMessageType.Exception_WebApi, ex: ex);

				if (System.Diagnostics.Debugger.IsAttached)
				System.Diagnostics.Debugger.Break();

				return InternalServerError();
			}
		}

		partial void RunCustomLogicAfterInsert(entBB.NotificationMethodType newDBItem);

	partial void RunCustomLogicAfterGetQueryableByPK(ref IQueryable<entBB.NotificationMethodType> dbItems, int notificationMethodTypeId);

	/// <summary>
	/// A sample implementation of custom logic used to include related entities to return with a DTO.
	/// </summary>
	/// <param name="dbItem"></param>
	/// <param name="id"></param>
	// partial void RunCustomLogicAfterGetQueryableByPK(ref IQueryable<entMmsInstance.SecurityPermissionGroup> qryItem, System.Guid id)
	// {
		// qryItem = qryItem.Include(x => x.RelatedParentEntity)
			// .Include(x => x.RelatedChildEntities);

	// }

	partial void RunCustomLogicAfterGetQueryableList(ref IQueryable<entBB.NotificationMethodType> dbItems, ref List<string> filterList);

	/// <summary>
	/// A sample implementation of custom logic used to filter on a field that exists in a related, parent, table.
	/// </summary>
	/// <param name="dbItems"></param>
	/// <param name="filterList"></param>
	//partial void RunCustomLogicAfterGetQueryableList(ref IQueryable<entBB.NotificationMethodType> dbItems, ref List<string> filterList)
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
