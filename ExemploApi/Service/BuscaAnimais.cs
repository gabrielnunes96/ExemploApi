using ExemploApi.Controllers.Modelos;
namespace ExemploApi.Service
{
    public class BuscaAnimais
    {

        public List<Gato> busca()
        {
            int arraySize = 3;
            var path = new StreamReader(@"C:\Users\gabri\Documents\LEITURABICHO.txt");
            List<Gato> retorno = new List<Gato>();

            while (!path.EndOfStream)
            {
                var pathline = path.ReadLine();
                if (pathline == null)
                    continue;

                String[] line = pathline.Split("|");
                if (line.Length != arraySize)
                    continue;
                if (line[0].ToLower().Contains("gato"))
                {
                    if (float.TryParse(line[2], out float y))
                    {
                        var Gato = new Gato(line[1], y);
                        if (Gato.Valido())
                            retorno.Add(Gato);
                    }
                }
            }
            
            return retorno;
        }
    }
}