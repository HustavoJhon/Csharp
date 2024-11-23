var poderVolar = new SuperPoder();

poderVolar.Nombre = "Volar";
poderVolar.Descripcion = "Capacidad para volar y planear en el aire";
poderVolar.Nivel = NivelPoder.NivelDos;

var superFuerza = new SuperPoder();
superFuerza.Nombre = "Super fuerza";
superFuerza.Nivel = NivelPoder.NivelTres;


var superman = new SuperHeroe();

superman.Id = 1;
superman.Nombre = "Superman";
superman.IdentidadSecreta = "Clark Kent";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;

List<SuperPoder> poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(poderVolar);
poderesSuperman.Add(superFuerza);
superman.SuperPoderes = poderesSuperman;
superman.UsarSuperPoderes();

class SuperHeroe
{
    public int Id;
    public string Nombre;
    public string IdentidadSecreta;
    public string Ciudad;
    public List<SuperPoderes> SuperPoderes;
    public bool PuedeVolar;

    public SuperHeroe()
    {
        Id = 1;
        SuperPoderes = new List<SuperPoder>();
        PuedeVolar = false;
    }

    public string UsarSuperPoderes()
    {
        foreach (var item in SuperPoderes)
        {
            Console.WriteLine($"{Nombre} esta usando el super poder {item.Nombre}");
        }
    }
}

class SuperPoder
{
    public string Nombre;
    public string Descripcion;
    public int Nivel;

    public SuperPoder()
    {
        Nivel = NivelPoder.NivelUno;
    }
}

enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres
}
