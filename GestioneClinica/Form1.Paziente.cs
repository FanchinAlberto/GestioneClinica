namespace GestioneClinica
{
    public partial class Form1
    {
        class Paziente
        {
            public string Nome { get; set; }
            public string Cognome { get; set; }
            public string Id { get; set; }
            public string Patologia { get; set; }

            public string Nomecognome { get; set; }
            public Paziente(string name, string surname, string id, string pat)
            {
                Nome = name;    
                Cognome = surname;
                Id = id;
                Patologia = pat;
                Nomecognome = $"{Nome} {Cognome}";
            }

            public string GetName()
            {
                return $"{Nome} {Cognome}";
            }

        }
    }
}
