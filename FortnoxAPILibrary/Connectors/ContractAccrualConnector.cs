using FortnoxAPILibrary.Entities;

// ReSharper disable UnusedMember.Global

namespace FortnoxAPILibrary.Connectors
{
    public interface IContractAccrualConnector : IEntityConnector<Sort.By.ContractAccrual?>
    {
        /// <summary>
        /// Get an contract accrual	
        /// </summary>
        /// <param name="contractNumber">The contract number of the contract accrual to get</param>
        /// <returns>The found contract accrual</returns>
        ContractAccrual Get(string contractNumber);

        /// <summary>
        /// Updates an contract accrual
        /// </summary>
        /// <param name="contractAccrual">The contract accrual to update</param>
        /// <returns>The updated contract accrual</returns>
        ContractAccrual Update(ContractAccrual contractAccrual);

        /// <summary>
        /// Create a new contract accrual
        /// </summary>
        /// <param name="contractAccrual">The contract accrual to create</param>
        /// <returns>The created contract accrual</returns>
        ContractAccrual Create(ContractAccrual contractAccrual);

        /// <summary>
        /// Deletes an contract accrual
        /// </summary>
        /// <param name="contractNumber">The contract number of the contract accrual to delete</param>
        void Delete(string contractNumber);

        /// <summary>
        /// Gets a list of contract accruals
        /// </summary>
        /// <returns>A list of contract accruals</returns>
        EntityCollection<ContractAccrualSubSet> Find();
    }

    /// <remarks/>
    public class ContractAccrualConnector : EntityConnector<ContractAccrual, EntityCollection<ContractAccrualSubSet>, Sort.By.ContractAccrual?>, IContractAccrualConnector
    {
		/// <remarks/>
        public ContractAccrualConnector()
		{
			Resource = "contractaccruals";
		}

        /// <summary>
        /// Get an contract accrual	
        /// </summary>
        /// <param name="contractNumber">The contract number of the contract accrual to get</param>
        /// <returns>The found contract accrual</returns>
        public ContractAccrual Get(string contractNumber)
        {
            return BaseGet(contractNumber);
        }

        /// <summary>
        /// Updates an contract accrual
        /// </summary>
        /// <param name="contractAccrual">The contract accrual to update</param>
        /// <returns>The updated contract accrual</returns>
        public ContractAccrual Update(ContractAccrual contractAccrual)
        {
            return BaseUpdate(contractAccrual, contractAccrual.DocumentNumber);
        }

        /// <summary>
        /// Create a new contract accrual
        /// </summary>
        /// <param name="contractAccrual">The contract accrual to create</param>
        /// <returns>The created contract accrual</returns>
        public ContractAccrual Create(ContractAccrual contractAccrual)
        {
            return BaseCreate(contractAccrual);
        }

        /// <summary>
        /// Deletes an contract accrual
        /// </summary>
        /// <param name="contractNumber">The contract number of the contract accrual to delete</param>
        public void Delete(string contractNumber)
        {
            BaseDelete(contractNumber);
        }

        /// <summary>
        /// Gets a list of contract accruals
        /// </summary>
        /// <returns>A list of contract accruals</returns>
        public EntityCollection<ContractAccrualSubSet> Find()
        {
            return BaseFind();
        }
    }
}
