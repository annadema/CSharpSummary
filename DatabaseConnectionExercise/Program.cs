using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectionExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection1=new SqlConnection("stringa di connessione al DB");
            connection1.Open();
            connection1.Close();
        }
    }
}
