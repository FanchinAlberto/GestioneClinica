namespace GestioneClinica
{
    public partial class Form1
    {
        class Medico
        {
            public string Nome { get; set; }
            public string Cognome { get; set;}
            public string Id { get; set; }
            public string Specializzazione { get; set; }
            public string Nomecognome { get; set; }

            public Medico(string name, string surname, string id, string spec)
            {
                Nome = name;
                Cognome = surname;
                Id = id;
                Specializzazione = spec;
                Nomecognome = $"{Nome} {Cognome}";
            }
            public string GetName()
            {
                return $"{Nome} {Cognome}";
            }
        }
    }
}
