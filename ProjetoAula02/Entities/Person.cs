namespace ProjetoAula02.Entities
{
    /// <summary>
    ///  Class to represent a person.
    /// </summary>
    public class Person
    {
        #region Attributes
        public Guid? _id { get; set; }
        public string? _name { get; set; }
        #endregion

        #region Properties
        public Guid? Id
        {
            set { _id = value; }
            get { return _id; }
        }

        public string? Name
        {
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentNullException(value);

                _name = value;
            }
            get { return _name; }
        }
        #endregion
    }
}
