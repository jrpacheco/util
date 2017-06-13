using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CNPJCPF
{
    public delegate void StatusInterno(int progress, string statusTexto);

    public class Controle
    {
        //public event StatusInterno StatusEvento;

        //public void TempoConsumoProcesso(string item)
        //{

            //StatusEvento(10, "Task-1 iniciou. Task-1 esta em processo...");
            //Task1();            
            //StatusEvento(20, "Task-1 finalizou. Task-2 esta em processo...");
            //Task2();
            //StatusEvento(40, "Task-2 finalizou. Task-3 esta em processo...");
            //Task3();
            //StatusEvento(60, "Task-3 finalizou. Task-4 esta em processo...");
            //Task4();
            //StatusEvento(80, "Task-4 finalizou. Task-5 esta em processo...");
            //Task5();
            //StatusEvento(100, "Task-5 finalizou. Todas as tarefas foram completadas com sucesso!");            
        //}    
        
        public async Task<string> RemoveCaracteresTask(string item)
        {            
            try
            {
                string retorno =  await Task.FromResult(RemoveCaracteres(item));                
                return retorno;
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

        public async Task<List<string>> RemoveCaracteresTask(string[] itens)
        {
            List<string> lista = new List<string>();

            try
            {
                foreach (var i in itens)
                {
                    lista.Add(RemoveCaracteres(i));
                }

                return await Task.FromResult(lista);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<string>> RemoveIntensDuplicadosTask(string[] item)
        {
            try
            {
                List<string> lista = new List<string>();

                lista =  await Task.FromResult(RemoveIntensDuplicados(item));
                                
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string RemoveCaracteres(string item)
        {
            try
            {
                return item.Replace(".", "").Replace("-", "").Replace("/", "");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private List<string> RemoveIntensDuplicados(string[] lista)
        {
            try
            {
                var dicionarioArray = lista
               .GroupBy(x => x)
               .ToDictionary(x => x.Key, x => x.ToArray());

                var listaDeDuplicatasAgrupadasEmArrays = dicionarioArray
                    .Select(x => x.Value.First())
                    .ToList();

                return listaDeDuplicatasAgrupadasEmArrays;
            }
            catch (Exception ex)
            {
                throw ex;
            }           
        }

        //private void Task5()
        //{
        //    Thread.Sleep(5000);
        //}

        //private void Task4()
        //{
        //    Thread.Sleep(4000);
        //}

        //private void Task3()
        //{
        //    Thread.Sleep(3000);
        //}

        //private void Task2()
        //{
        //    Thread.Sleep(2000);
        //}

        //private void Task1()
        //{
        //    Thread.Sleep(1000);
        //}
    }
}
