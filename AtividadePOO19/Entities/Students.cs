using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePOO19.Entities
{
    internal class Students
    {
        public HashSet<int> ConjuntoDeEstudantesA;
        public HashSet<int> ConjuntoDeEstudantesB;
        public HashSet<int> ConjuntoDeEstudantesC;

        public Students(HashSet<int> conjuntoDeEstudantesA, HashSet<int> conjuntoDeEstudantesB, HashSet<int> conjuntoDeEstudantesC)
        {
            ConjuntoDeEstudantesA = conjuntoDeEstudantesA;
            ConjuntoDeEstudantesB = conjuntoDeEstudantesB;
            ConjuntoDeEstudantesC = conjuntoDeEstudantesC;
        }

        public int TotalAlunos()
        { 
            ConjuntoDeEstudantesA.UnionWith(ConjuntoDeEstudantesB);
            ConjuntoDeEstudantesA.UnionWith(ConjuntoDeEstudantesC);

            return ConjuntoDeEstudantesA.Count();
        }
    }
}
