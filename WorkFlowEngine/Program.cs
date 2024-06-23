using System.Collections;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var workFlowEngine=new WorkFlowEngine();

            var workFlow=new WorkFlow();



            workFlow.Add(new UploadVideo());
            workFlow.Add(new CallWebService());
            workFlow.Add(new SendEmail());
            workFlow.Add(new ChangeStatus());

            workFlowEngine.Run(workFlow);

        }
    }
}
