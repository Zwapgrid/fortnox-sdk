using FortnoxAPILibrary.Entities;

// ReSharper disable UnusedMember.Global

namespace FortnoxAPILibrary.Connectors
{
    public interface ILabelConnector : IEntityConnector<Sort.By.Label?>
    {
        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        string Id { get; set; }

        /// <summary>
        /// Gets a Label by ID
        /// </summary>
        /// <param name="labelId"></param>
        /// <returns></returns>
        Label Get(string labelId);

        /// <summary>
        /// Updates a label
        /// </summary>
        /// <param name="label"></param>
        /// <returns></returns>
        Label Update(Label label);

        /// <summary>
        /// Create a new label
        /// </summary>
        /// <param name="label">The label entity to create</param>
        /// <returns>The created label.</returns>
        Label Create(Label label);

        /// <summary>
        /// Delete a label
        /// </summary>
        /// <param name="labelid">The label id to delete</param>
        /// <returns>If the label was deleted. </returns>
        void Delete(string labelid);

        /// <summary>
        /// Gets a list of labels
        /// </summary>
        /// <returns>A list of labels</returns>
        EntityCollection<LabelSubset> Find();
    }

    /// <remarks/>
    public class LabelConnector : EntityConnector<Label, EntityCollection<LabelSubset>, Sort.By.Label?>, ILabelConnector
    {
        /// <summary>
        /// Use with Find() to limit the search result
        /// </summary>
        [SearchParameter]
        public string Id { get; set; }

        /// <remarks/>
        public LabelConnector() {
            Resource = "labels";
        }

        /// <summary>
        /// Gets a Label by ID
        /// </summary>
        /// <param name="labelId"></param>
        /// <returns></returns>
        public Label Get(string labelId) {
            return BaseGet(labelId);
        }

        /// <summary>
        /// Updates a label
        /// </summary>
        /// <param name="label"></param>
        /// <returns></returns>
        public Label Update(Label label) {
            return BaseUpdate(label, label.Id);
        }

        /// <summary>
        /// Create a new label
        /// </summary>
        /// <param name="label">The label entity to create</param>
        /// <returns>The created label.</returns>
        public Label Create(Label label) {
            return BaseCreate(label);
        }

        /// <summary>
        /// Delete a label
        /// </summary>
        /// <param name="labelid">The label id to delete</param>
        /// <returns>If the label was deleted. </returns>
        public void Delete(string labelid) {
            BaseDelete(labelid);
        }

        /// <summary>
        /// Gets a list of labels
        /// </summary>
        /// <returns>A list of labels</returns>
        public EntityCollection<LabelSubset> Find() {
            return BaseFind();
        }
    }
}
