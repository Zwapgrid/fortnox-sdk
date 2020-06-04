
using FortnoxAPILibrary.Entities;

// ReSharper disable UnusedMember.Global

namespace FortnoxAPILibrary.Connectors
{
    public interface IUnitConnector : IEntityConnector<Sort.By.Unit?>
    {
        /// <summary>
        /// Gets a unit based on unit code
        /// </summary>
        /// <param name="unitCode">The unit code to find</param>
        /// <returns>The found unit</returns>
        Unit Get(string unitCode);

        /// <summary>
        /// Updates a unit
        /// </summary>
        /// <param name="unit">Unit to update</param>
        /// <returns>The updated unit</returns>
        Unit Update(Unit unit);

        /// <summary>
        /// Create a new unit
        /// </summary>
        /// <param name="unit">The unit to create</param>
        /// <returns>The created unit</returns>
        Unit Create(Unit unit);

        /// <summary>
        /// Deletes a unit
        /// </summary>
        /// <param name="unitCode">The unit code to delete</param>
        /// <returns>If the unit was deleted or not.</returns>
        void Delete(string unitCode);

        /// <summary>
        /// Gets a list of units
        /// </summary>
        /// <returns>A list of units</returns>
        EntityCollection<UnitSubset> Find();
    }

    /// <remarks/>
	public class UnitConnector : EntityConnector<Unit, EntityCollection<UnitSubset>, Sort.By.Unit?>, IUnitConnector
    {
		/// <remarks/>
		public UnitConnector()
		{
			Resource = "units";
		}

		/// <summary>
		/// Gets a unit based on unit code
		/// </summary>
		/// <param name="unitCode">The unit code to find</param>
		/// <returns>The found unit</returns>
		public Unit Get(string unitCode)
		{
			return BaseGet(unitCode);
		}

		/// <summary>
		/// Updates a unit
		/// </summary>
		/// <param name="unit">Unit to update</param>
		/// <returns>The updated unit</returns>
		public Unit Update(Unit unit)
		{
			return BaseUpdate(unit, unit.Code);
		}

		/// <summary>
		/// Create a new unit
		/// </summary>
		/// <param name="unit">The unit to create</param>
		/// <returns>The created unit</returns>
		public Unit Create(Unit unit)
		{
			return BaseCreate(unit);
		}

		/// <summary>
		/// Deletes a unit
		/// </summary>
		/// <param name="unitCode">The unit code to delete</param>
		/// <returns>If the unit was deleted or not.</returns>
		public void Delete(string unitCode)
		{
			BaseDelete(unitCode);
		}

		/// <summary>
		/// Gets a list of units
		/// </summary>
		/// <returns>A list of units</returns>
		public EntityCollection<UnitSubset> Find()
		{
			return BaseFind();
		}
	}
}
