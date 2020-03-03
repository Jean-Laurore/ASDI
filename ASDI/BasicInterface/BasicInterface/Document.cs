using System;
namespace BasicInterface
{
    interface IStorable
    {
        void Save();
        void Load();
        Boolean NeedSave { get; set; }
    }

    public class Document : IStorable
    {
        private string name;
        private Boolean mNeedSave = false;

        public Document(string s)
        {
            name = s;
            Console.WriteLine("Created a document with name '{0}'", s);
        }

        public void Save()
        {
            Console.WriteLine("Saving the document");
        }

        public void Load()
        {
            Console.WriteLine("Loading the document");
        }

        public Boolean NeedSave
        {
            get { return mNeedSave; }
            set { mNeedSave = value; }
        }
    }
}
