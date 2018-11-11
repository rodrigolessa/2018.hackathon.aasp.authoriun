using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Authoriun.EtherConsole.Entities;

namespace Authoriun.EtherConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var db = new AuthoriunContext();
                var transac = new Transacoes();

                foreach (Registro r in db.Registro.Where(x => x.Status == 1).ToList())
                {
                    var hash = transac.CriarTransacoesAsync(r.Arquivo.SHA256, r.Arquivo.SHA256);

                    var tp = hash.Result;

                    if (string.IsNullOrWhiteSpace(tp.Item1))
                        r.Status = 3;
                    else
                    {
                        r.HashTransacao = tp.Item1;
                        r.CriadoEm = tp.Item2;
                        r.Status = 2;
                    }

                    db.Entry(r).State = EntityState.Modified;
                }

                db.SaveChanges();
            }
        }
    }
}
