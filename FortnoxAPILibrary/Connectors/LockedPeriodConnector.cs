using FortnoxAPILibrary.Entities;

// ReSharper disable UnusedMember.Global

namespace FortnoxAPILibrary.Connectors
{
    public interface ILockedPeriodConnector : IEntityConnector<Sort.By.LockedPeriod?>
    {
        /// <summary>
        /// Gets the locked period setting
        /// </summary>
        /// <returns>The locked period setting</returns>
        LockedPeriod Get();
    }

    /// <remarks/>
    public class LockedPeriodConnector : EntityConnector<LockedPeriod, EntityWrapper<LockedPeriod>, Sort.By.LockedPeriod?>, ILockedPeriodConnector
    {
        /// <remarks/>
        public LockedPeriodConnector()
        {
            Resource = "settings/lockedperiod";
        }

        /// <summary>
        /// Gets the locked period setting
        /// </summary>
        /// <returns>The locked period setting</returns>
        public LockedPeriod Get()
        {
            return BaseFind().Entity;
        }
    }
}
