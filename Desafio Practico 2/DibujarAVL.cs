using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Desafio_Practico_2
{
    class DibujarAVL
    {
        public AVL Raiz;
        public AVL aux;

        //Constructor
        public DibujarAVL()
        {
            aux = new AVL();
        }

        public DibujarAVL(AVL RaizNueva)
        {
            Raiz = RaizNueva;
        }

        //Agrega un nuevo valor al arbol

        public void Insertar(int dato)
        {
            if (Raiz == null)
            {
                Raiz = new AVL(dato, null, null, null);
            }
            else
            {
                Raiz = Raiz.Insertar(dato, Raiz);
            }
        }
        //Eliminar un valor del arbol
        public void Eliminar(int dato)
        {
            if (Raiz == null)
            {
                Raiz = new AVL(dato, null, null, null);
            }
            else
            {
                Raiz.Eliminar(dato, ref Raiz);
            }
        }

        private const int Radio = 30;
        private const int DistanciaX = 40;
        private const int DistanciaY = 10;

        private int CoordenadaX;
        private int CoordenadaY;

        public void PosicionNodoRecorrido(ref int xmin, ref int ymin)
        {
            CoordenadaY = (int)(ymin + Radio / 2);
            CoordenadaX = (int)(xmin + Radio / 2);
            xmin += Radio;
        }




        //Dibujar Arbol
        public void DibujarArbol(Graphics grafo, Font fuente, Brush relleno, Brush RellenoFuente, Pen lapiz, int dato, Brush encuentro)
        {

            int x = 100;
            int y = 75;
            if (Raiz == null)
            {
                return;
            }

            //Poosicion de todo los nodos
            Raiz.PosicionNodo(ref x, y);

            //Dibuja los enlaces entre nodos
            Raiz.DibujarRamas(grafo, lapiz);

            //Dibujar todos los nodos
            Raiz.DibujarNodo(grafo, fuente, relleno, RellenoFuente, lapiz, dato, encuentro);
        }

        public int x1 = 100;
        public int y2 = 75;
        public void Reestrablecer_valores()
        {
            x1 = 100;
            y2 = 75;
        }
    }
}
