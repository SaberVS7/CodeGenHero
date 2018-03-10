// <auto-generated> - Template:WebApiControllerPartialMethods, Version:1.0, Id:54f0612b-5235-437d-af2d-0b75efa68630
using System.Data.Entity;
using System.Linq;
using entBB = CodeGenHero.BingoBuzz.Repository.Entities.BB;

namespace CodeGenHero.BingoBuzz.API.Controllers.BB
{
	public partial class FrequencyTypesBBController : BBBaseApiController
	{
		/// <summary>
		/// A sample implementation of custom logic used to include related entities to return with a DTO.
		/// </summary>
		/// <param name="qryItem"></param>
		/// <param name="id"></param>
		/// <param name="numChildLevels"></param>
		 partial void RunCustomLogicOnGetQueryableByPK(ref IQueryable<entBB.FrequencyType> qryItem, int frequencyTypeId, int numChildLevels)
		 {
			 if (numChildLevels > 0)
			 {
				 qryItem = qryItem;
				 // .Include(x => x.RecurrenceRules).AsNoTracking(); -- Excluded navigation property per configuration.
			 }
		 }

		///// <summary>
		///// A sample implementation of custom logic used to either manipulate a DTO item or include related entities.
		///// </summary>
		///// <param name="dbItem"></param>
		///// <param name="id"></param>
		///// <param name="numChildLevels"></param>
		// partial void RunCustomLogicOnGetEntityByPK(ref entBB.FrequencyType dbItem, int frequencyTypeId, int numChildLevels)
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

		///// <summary>
		///// A sample implementation of custom logic used to filter on a field that exists in a related, parent, table.
		///// </summary>
		///// <param name="dbItems"></param>
		///// <param name="filterList"></param>
		//partial void RunCustomLogicAfterGetQueryableList(ref IQueryable<entBB.FrequencyType> dbItems, ref List<string> filterList)
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
