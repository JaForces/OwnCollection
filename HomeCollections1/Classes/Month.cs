namespace HomeCollections1
{
    class Month
    {
        private string name;
        private int id;
        private int days;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public int Days
        {
            get { return this.days; }
            set { this.days = value; }
        }
        public Month(string name, int days, int id)
        {
            this.name = name;
            this.days = days;
            this.id = id;
        }
    }
}
