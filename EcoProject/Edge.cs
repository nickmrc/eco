using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoProject
{
 public   class Edge
    {
        public Vertex V1;
        public Vertex V2;
        public Edge brother;
        public bool isOutside = false;

        public float Volume { get; set; }
        public float Density = -1f;

        public Edge(Vertex v1, Vertex v2)
        {
            this.V1 = v1;
            this.V2 = v2;
        }

        public void Update()
        {
            brother = null;
            isOutside = false;
            Volume = new float();
            Density = -1f;
        }

        public override bool Equals(object obj)
        {
            Edge edgeObj = obj as Edge;

            bool trushka = false; 

            if (edgeObj == null)
                return false;

            if (this.V1.Equals(edgeObj.V1))
            {
                if (this.V2.Equals(edgeObj.V2))
                {
                    trushka = true;
                }
            }
            else
            {
                if (this.V1.Equals(edgeObj.V2))
                {
                    if (this.V2.Equals(edgeObj.V1))
                    {
                        trushka = true;
                    }

                }
            }

            if (trushka)
            {
            }
            return trushka;
        }

        public override string ToString()
        {
            string s = "";
            s += "V= " + this.Volume+"  ";
            s += "{ "+ this.V1.ToString() +" ; "+ this.V2.ToString()+ " } ";
            
            return s;
        }
    }
}
