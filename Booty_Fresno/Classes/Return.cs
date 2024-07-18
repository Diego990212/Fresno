namespace Booty_Fresno.Classes
{
    public class Return
    {
        public List<Message> Answers { get; set; }
        public Entry Question { get; set; }
        public Tools Helper { get; set; }
        public Tooltip Hint { get; set; }
        public Options Parameters { get; set; }
        public class Message
        {
            public _Text Text { get; set; }
            public _File File { get; set; }
            public _Link Link { get; set; }
            public _Image Image { get; set; }
            public _Pdf Pdf { get; set; }
            public _Audio Audio { get; set; }
            public _Video Video { get; set; }
            public class _Image
            {
                public string FileName { get; set; }
                public byte[] Content { get; set; }
            }
            public class _Pdf
            {
                public string FileName { get; set; }
                public byte[] Content { get; set; }
            }
            public class _Text
            {
                public string Text { get; set; }
                public bool Password { get; set; }
            }
            public class _Video
            {
                public string FileName { get; set; }
                public byte[] Content { get; set; }
            }
            public class _File
            {
                public string FileName { get; set; }
                public byte[] Content { get; set; }
            }
            public class _Link
            {
                public string Link { get; set; }
                public string Text { get; set; }
            }
            public class _Audio
            {
                public string FileName { get; set; }
                public byte[] Content { get; set; }
            }
        }
        public class Entry
        {
            public _Input Input { get; set; }
            public _Area Area { get; set; }
            public _List List { get; set; }
            public _Checklist Checklist { get; set; }
            public _Scanner Scanner { get; set; }
            public _File File { get; set; }
            public _Table Table { get; set; }
            public class _Input
            {
                public _Text Text { get; set; }
                public _Number Number { get; set; }
                public _Date Date { get; set; }
                public _Time Time { get; set; }
                public _DateTime DateTime { get; set; }
                public _Password Password { get; set; }
                public class _Text
                {
                    public string Placeholder { get; set; }
                    public string Value { get; set; }
                }
                public class _Number
                {
                    public double Value { get; set; }
                }
                public class _Date
                {
                    public string Value { get; set; }
                }
                public class _Time
                {
                    public string Value { get; set; }
                }
                public class _DateTime
                {
                    public string Value { get; set; }
                }
                public class _Password
                {
                    public int MaxLength { get; set; }
                    public string Placeholder { get; set; }
                    public string Value { get; set; }
                }
            }
            public class _File
            {
                public bool Multiple { get; set; }
                public string Label { get; set; }
                public string Accept { get; set; }
            }
            public class _Scanner
            {
                public string Placeholder { get; set; }
            }
            public class _Area
            {
                public string Placeholder { get; set; }
            }
            public class _List
            {
                public List<_Options> Options { get; set; }
                public class _Options
                {
                    public string Value { get; set; }
                    public string Text { get; set; }
                }
            }
            public class _Checklist
            {
                public List<_Options> Options { get; set; }
                public class _Options
                {
                    public string Value { get; set; }
                    public string Text { get; set; }
                }
            }
            public class _Table
            {
                public string Question { get; set; }
                public string Response { get; set; }
                public List<_Entries> Entries { get; set; }

                public class _Entries
                {
                    public string Question { get; set; }
                    public _Response Response { get; set; }

                    public class _Response
                    {
                        public _Input Input { get; set; }
                        public _Area Area { get; set; }
                        public _List List { get; set; }
                        public class _Input
                        {
                            public _Text Text { get; set; }
                            public _Number Number { get; set; }
                            public _Date Date { get; set; }
                            public _Time Time { get; set; }
                            public _DateTime DateTime { get; set; }
                            public _Password Password { get; set; }
                            public class _Text
                            {
                                public string Placeholder { get; set; }
                                public string Value { get; set; }
                            }
                            public class _Number
                            {
                                public double Value { get; set; }
                            }
                            public class _Date
                            {
                                public string Value { get; set; }
                            }
                            public class _Time
                            {
                                public string Value { get; set; }
                            }
                            public class _DateTime
                            {
                                public string Value { get; set; }
                            }
                            public class _Password
                            {
                                public int MaxLength { get; set; }
                                public string Placeholder { get; set; }
                                public string Value { get; set; }
                            }
                        }
                        public class _Area
                        {
                            public string Placeholder { get; set; }
                        }
                        public class _List
                        {
                            public List<_Options> Options { get; set; }
                            public class _Options
                            {
                                public string Value { get; set; }
                                public string Text { get; set; }
                            }
                        }
                    }

                }
            }
        }
        public class Options
        {
            public int Status { get; set; }
        }
        public class Tools
        {
            public bool Append { get; set; }
            public bool Remove { get; set; }
            public List<Toolkit> Toolkits { get; set; }
            public class Toolkit
            {
                public _Text Text { get; set; }
                public _File File { get; set; }
                public _Link Link { get; set; }
                public _Image Image { get; set; }
                public _Pdf Pdf { get; set; }
                public _Audio Audio { get; set; }
                public _Video Video { get; set; }
                public class _Image
                {
                    public string FileName { get; set; }
                    public byte[] Content { get; set; }
                }
                public class _Pdf
                {
                    public string FileName { get; set; }
                    public byte[] Content { get; set; }
                }
                public class _Text
                {
                    public string Text { get; set; }
                }
                public class _Video
                {
                    public string FileName { get; set; }
                    public byte[] Content { get; set; }
                }
                public class _File
                {
                    public string FileName { get; set; }
                    public byte[] Content { get; set; }
                }
                public class _Link
                {
                    public string Link { get; set; }
                    public string Text { get; set; }
                }
                public class _Audio
                {
                    public string FileName { get; set; }
                    public byte[] Content { get; set; }
                }
            }
        }
        public class Tooltip
        {
            public _Text Text { get; set; }
            public class _Text
            {
                public string Text { get; set; }
            }
        }
    }
}
