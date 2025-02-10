namespace IDELangugesDemo
{
    internal class Program
    {
        //public IDE ide { get; set; }
        //IDE ide = new IDE(); // HAS-A
        static void Main(string[] args)
        {
            IDE ide = new IDE(); // Uses

            LangCSharp cs = new LangCSharp();
            ide.Languages.Add(cs);
            LangC langC = new LangC();
            //ide.Languages.Add(langC);
            LangJava langJava = new LangJava();
            ide.Languages.Add(langJava);
            LangTypeScript ts = new LangTypeScript();
            ide.Languages.Add(ts);

            ide.DoWork();
        }
    }

    class IDE   // OCP
    {
        //public LangCSharp CS { get; set; }
        //public LangJava Java { get; set; }
        //public LangC C { get; set; }

        public List<ILanguage> Languages { get; set; } = new List<ILanguage>();

        public void DoWork()
        {
            // CS
            foreach (var lang in Languages)
            {
                Console.WriteLine(lang.GetName());
                Console.WriteLine(lang.GetUnit());
                Console.WriteLine(lang.GetParadigm());
            }
            //// Java
            //Console.WriteLine(Java.GetName());
            //Console.WriteLine(Java.GetUnit());
            //Console.WriteLine(Java.GetParadigm());
            //// C
            //Console.WriteLine(C.GetName());
            //Console.WriteLine(C.GetUnit());
            //Console.WriteLine(C.GetParadigm());
        }
    }

    interface ILanguage
    {
        string GetName();


        string GetUnit();


        string GetParadigm();
    }

    abstract class OOLanguage : ILanguage
    {
        abstract public string GetName();


        public string GetParadigm()
        {
            return "Object Oriented";
        }

        public string GetUnit()
        {
            return "Classes";
        }
    }
    abstract class ProcLanguage : ILanguage
    {
        public abstract string GetName();
        public string GetUnit() { return "Functions"; }
        public string GetParadigm() { return "Procedure Oriented"; }
    }

    class LangTypeScript : OOLanguage
    {
        public override string GetName()
        {
            return "TypeScript";
        }

        //public string GetParadigm()
        //{
        //    return "Object Oriented";
        //}

        //public string GetUnit()
        //{
        //    return "Classes";
        //}
    }

    class LangCSharp : OOLanguage
    {
        public override string GetName() { return "C Sharp"; }
        //public string GetUnit() { return "Classes"; }
        //public string GetParadigm() { return "Object Oriented"; }
    }
    class LangJava : OOLanguage
    {
        public override string GetName() { return "Java"; }
        //public string GetUnit() { return "Classes"; }
        //public string GetParadigm() { return "Object Oriented"; }
    }
    class LangC : ProcLanguage
    {
        public override string GetName() { return "C Language"; }
        //public string GetUnit() { return "Functions"; }
        //public string GetParadigm() { return "Procedure Oriented"; }
    }
}
