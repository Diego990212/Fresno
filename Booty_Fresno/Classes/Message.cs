namespace Booty_Fresno.Classes
{
    public class Message
    {
        public string Text { get; set; }
        public string Username { get; set; }
        public string Chatusername { get; set; }
        public int? Status { get; set; }
        public List<UploadedFile> UploadesFiles { get; set; }
        public _Table? Table { get; set; }
        public class UploadedFile
        {
            public string FileName { get; set; }
            public byte[] Content { get; set; }
        }
        public List<Querys> Parameters { get; set; }
        public class Querys
        {
            public string Parameter { get; set; }
            public string Value { get; set; }
        }
        public class _Table
        {
            public string Question { get; set; }
            public string Response { get; set; }
            public List<_Answers> Answers { get; set; }
            public class _Answers
            {
                public string Field { get; set; }
                public string Value { get; set; }
            }
        }
    }
}
