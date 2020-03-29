using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Desafio_Practico_2
{
    class AVL
    {
        public int valor;
        public AVL NodoIzquierdo;
        public AVL NodoDerecho;
        public AVL NodoPadre;
        public int altura;
        private DibujarAVL arbol;

        //Constructor vacio
        public AVL()
        {

        }

        public DibujarAVL Arbol
        {
            get { return arbol; }
            set { arbol = value; }
        }

        //Constructor
        public AVL(int ValorNuevo, AVL izquierdo, AVL derecho, AVL padre)
        {
            valor = ValorNuevo;
            NodoIzquierdo = izquierdo;
            NodoDerecho = derecho;
            NodoPadre = padre;
            altura = 0;
        }

        #region Insercion
        //Funcion para insertar un nuevo valor en el arbol AVL
        public AVL Insertar(int ValorNuevo, AVL Raiz)
        {
            if (Raiz == null)
            {
                Raiz = new AVL(ValorNuevo, null, null, null);
            }
            else if (ValorNuevo < Raiz.valor)
            {
                Raiz.NodoIzquierdo = Insertar(ValorNuevo, Raiz.NodoIzquierdo);
            }
            else if (ValorNuevo > Raiz.valor)
            {
                Raiz.NodoDerecho = Insertar(ValorNuevo, Raiz.NodoDerecho);
            }
            else
            {
                MessageBox.Show("Valor Existente en el Arbol", "Error", MessageBoxButtons.OK);
            }

            //Realiza las rotaciones simples o dobles segun el caso
            if (ObtenerBalance(Raiz) == 2)
            {
                if (ValorNuevo < Raiz.NodoIzquierdo.valor)
                {
                    Raiz = RotacionIzquierdaSimple(Raiz);
                }
                else
                {
                    Raiz = RotacionIzquierdaDoble(Raiz);
                }
            }
            if (ObtenerBalance(Raiz) == -2)
            {
                if (ValorNuevo < Raiz.NodoDerecho.valor)
                {
                    Raiz = RotacionDerechaDoble(Raiz);
                }
                else
                {
                    Raiz = RotacionDerechaSimple(Raiz);
                }
            }

            Raiz.altura = max(Alturas(Raiz.NodoIzquierdo), Alturas(Raiz.NodoIzquierdo)) + 1;
            return Raiz;
        }
        #endregion

        private int ObtenerBalance(AVL Raiz)
        {
            return (Alturas(Raiz.NodoIzquierdo) - Alturas(Raiz.NodoDerecho));
        }

        //FUNCION DE PRUEBA PARA REALIZAR LAS ROTACIONES

        //Función para obtener que rama es mayor
        private static int max(int lhs, int rhs)
        {
            return lhs > rhs ? lhs : rhs;
        }
        private static int Alturas(AVL Raiz)
        {
            return Raiz == null ? -1 : Raiz.altura;
        }

        #region Eliminar
        AVL NodoE, NodoP;
        public AVL Eliminar(int ValorEliminar, ref AVL Raiz)
        {
            if (Raiz != null)
            {
                if (ValorEliminar < Raiz.valor)
                {
                    NodoE = Raiz;
                    Eliminar(ValorEliminar, ref Raiz.NodoIzquierdo);
                }
                else
                {
                    if (ValorEliminar > Raiz.valor)
                    {
                        NodoE = Raiz;
                        Eliminar(ValorEliminar, ref Raiz.NodoDerecho);
                    }
                    else
                    {
                        //Posicionado sobre el elemento a eliminar

                        AVL NodoEliminar = Raiz;
                        if (NodoEliminar.NodoDerecho == null)
                        {
                            Raiz = NodoEliminar.NodoIzquierdo;
                            if (Alturas(NodoE.NodoIzquierdo) - Alturas(NodoE.NodoDerecho) == 2)
                            {
                                MessageBox.Show("Nodo E: " + NodoE.valor.ToString());
                                if (ValorEliminar < NodoE.valor)
                                {
                                    NodoP = RotacionIzquierdaSimple(NodoE);
                                }
                                else
                                {
                                    NodoE = RotacionDerechaSimple(NodoE);
                                }
                            }
                            if (Alturas(NodoE.NodoDerecho) - Alturas(NodoE.NodoIzquierdo) == 2)
                            {
                                if (ValorEliminar > NodoE.NodoDerecho.valor)
                                {
                                    NodoE = RotacionDerechaSimple(NodoE);
                                }
                                else
                                {
                                    NodoE = RotacionDerechaDoble(NodoE);
                                }
                                NodoP = RotacionDerechaSimple(NodoE);
                            }
                        }
                        else
                        {
                            if (NodoEliminar.NodoIzquierdo == null)
                            {
                                Raiz = NodoEliminar.NodoDerecho;
                            }
                            else
                            {
                                if (Alturas(Raiz.NodoIzquierdo) - Alturas(Raiz.NodoDerecho) > 0)
                                {
                                    AVL AuxiliarNodo = null;
                                    AVL Auxiliar = Raiz.NodoIzquierdo;
                                    bool Bandera = false;
                                    while (Auxiliar.NodoDerecho != null)
                                    {
                                        AuxiliarNodo = Auxiliar;
                                        Auxiliar = Auxiliar.NodoDerecho;
                                        Bandera = true;
                                    }
                                    Raiz.valor = Auxiliar.valor;
                                    NodoEliminar = Auxiliar;
                                    if (Bandera == true)
                                    {
                                        AuxiliarNodo.NodoDerecho = Auxiliar.NodoIzquierdo;
                                    }
                                    else
                                    {
                                        Raiz.NodoIzquierdo = Auxiliar.NodoIzquierdo;
                                    }
                                    //Realiza las rotaciones simples o dobles segun el caso
                                }
                                else
                                {
                                    if (Alturas(Raiz.NodoDerecho) - Alturas(Raiz.NodoIzquierdo) > 0)
                                    {
                                        AVL AuxiliarNodo = null;
                                        AVL Auxiliar = Raiz.NodoDerecho;
                                        bool Bandera = false;
                                        while (Auxiliar.NodoIzquierdo != null)
                                        {
                                            AuxiliarNodo = Auxiliar;
                                            Auxiliar = Auxiliar.NodoIzquierdo;
                                            Bandera = true;
                                        }
                                        Raiz.valor = Auxiliar.valor;
                                        NodoEliminar = Auxiliar;
                                        if (Bandera == true)
                                        {
                                            AuxiliarNodo.NodoIzquierdo = Auxiliar.NodoDerecho;
                                        }
                                        else
                                        {
                                            Raiz.NodoDerecho = Auxiliar.NodoDerecho;
                                        }
                                    }
                                    else
                                    {
                                        if (Alturas(Raiz.NodoDerecho) - Alturas(Raiz.NodoIzquierdo) == 0)
                                        {
                                            AVL AuxiliarNodo = null;
                                            AVL Auxiliar = Raiz.NodoIzquierdo;
                                            bool Bandera = false;
                                            while (Auxiliar.NodoDerecho != null)
                                            {
                                                AuxiliarNodo = Auxiliar;
                                                Auxiliar = Auxiliar.NodoDerecho;
                                                Bandera = true;
                                            }
                                            Raiz.valor = Auxiliar.valor;
                                            NodoEliminar = Auxiliar;
                                            if (Bandera == true)
                                            {
                                                AuxiliarNodo.NodoDerecho = Auxiliar.NodoIzquierdo;
                                            }
                                            else
                                            {
                                                Raiz.NodoIzquierdo = Auxiliar.NodoIzquierdo;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nodo inexistente en el arbol, Dato de la Cola no agregado al Arbol", "Error", MessageBoxButtons.OK);
            }
            return NodoP;
        }
        #endregion

        #region Rotaciones
        //Seccion de funciones de rotaciones
        //Rotacion Izquierda Simple
        private static AVL RotacionIzquierdaSimple(AVL k2)
        {
            MessageBox.Show("Rotacion Izquierda Simple");
            AVL k1 = k2.NodoIzquierdo;
            k2.NodoIzquierdo = k1.NodoDerecho;
            k1.NodoDerecho = k2;
            k2.altura = max(Alturas(k2.NodoIzquierdo), Alturas(k2.NodoDerecho)) + 1;
            k1.altura = max(Alturas(k1.NodoIzquierdo), k2.altura) + 1;
            return k1;
        }
        //Rotacion Derecha Simple
        private static AVL RotacionDerechaSimple(AVL k1)
        {
            MessageBox.Show("Rotacion Derecha Simple");
            AVL k2 = k1.NodoDerecho;
            k1.NodoDerecho = k2.NodoIzquierdo;
            k2.NodoIzquierdo = k1;
            k1.altura = max(Alturas(k1.NodoIzquierdo), Alturas(k1.NodoDerecho)) + 1;
            k2.altura = max(Alturas(k2.NodoDerecho), k1.altura) + 1;
            return k2;
        }
        //Doble Rotacion Izquierda
        private static AVL RotacionIzquierdaDoble(AVL k3)
        {
            MessageBox.Show("Rotacion Izquierda Doble");
            k3.NodoIzquierdo = RotacionDerechaSimple(k3.NodoIzquierdo);
            return RotacionIzquierdaSimple(k3);
        }
        //Doble Rotacion Derecha
        private static AVL RotacionDerechaDoble(AVL k1)
        {
            MessageBox.Show("Rotacion Derecha Doble");
            k1.NodoDerecho = RotacionIzquierdaSimple(k1.NodoDerecho);
            return RotacionDerechaSimple(k1);
        }
        #endregion

        #region ObtenerAltura
        //Funcion para obtener la altura del arbol
        public int ObtenerAltura(AVL NodoActual)
        {
            if (NodoActual == null)
            {
                return 0;
            }
            else
            {
                return 1 + Math.Max(ObtenerAltura(NodoActual.NodoIzquierdo), ObtenerAltura(NodoActual.NodoDerecho));
            }
        }
        #endregion

        //FUNCIONES PARA DIBUJAR EL ARBOL
        private const int Radio = 30;
        private const int DistanciaX = 40;
        private const int DistanciaY = 10;

        private int CoordenadaX;
        private int CoordenadaY;

        //Encuentra la posicion en donde debe crearse el nodo
        public void PosicionNodo(ref int xmin, int ymin)
        {
            int aux1, aux2;
            CoordenadaY = (int)(ymin + Radio / 2);
            //Obtiene la posicion del SubArbol Izquierdo
            if (NodoIzquierdo != null)
            {
                NodoIzquierdo.PosicionNodo(ref xmin, ymin + Radio + DistanciaY);
            }
            if ((NodoIzquierdo != null) && (NodoDerecho != null))
            {
                xmin += DistanciaX;
            }

            //Si existe el nodo derecho e izquierdo deja un espacio entre ellos
            if (NodoDerecho != null)
            {
                NodoDerecho.PosicionNodo(ref xmin, ymin + Radio + DistanciaY);
            }
            //Posicion de nodos derecho e izquierdo
            if (NodoIzquierdo != null)
            {
                if (NodoDerecho != null)
                {
                    //centro entre nodos
                    CoordenadaX = (int)((NodoIzquierdo.CoordenadaX + NodoDerecho.CoordenadaX) / 2);
                }
                else
                {
                    //No hay nodo derecho. centrar al nodo izquierdo
                    aux1 = NodoIzquierdo.CoordenadaX;
                    NodoIzquierdo.CoordenadaX = CoordenadaX - 40;
                    CoordenadaX = aux1;
                }
            }
            else if (NodoDerecho != null)
            {
                aux2 = NodoDerecho.CoordenadaX;
                //No hay izquierdo.cebtrar al nodo derecho
                NodoDerecho.CoordenadaX = CoordenadaX + 40;
                CoordenadaX = aux2;
            }
            else
            {
                //Nodo hoja
                CoordenadaX = (int)(xmin + Radio / 2);
                xmin += Radio;
            }
        }

        //Dibujar ramas de los nodos izquierdo y derecho
        public void DibujarRamas(Graphics grafo, Pen lapiz)
        {
            if (NodoIzquierdo != null)
            {
                grafo.DrawLine(lapiz, CoordenadaX, CoordenadaY, NodoIzquierdo.CoordenadaX, NodoIzquierdo.CoordenadaY);
                NodoIzquierdo.DibujarRamas(grafo, lapiz);
            }
            if (NodoDerecho != null)
            {
                grafo.DrawLine(lapiz, CoordenadaX, CoordenadaY, NodoDerecho.CoordenadaX, NodoDerecho.CoordenadaY);
                NodoDerecho.DibujarRamas(grafo, lapiz);
            }
        }

        //Dibuja el nodo en la posicion especifica
        public void DibujarNodo(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz, int dato, Brush encuentro)
        {
            //Dibujar contorno del nodo
            Rectangle rect = new Rectangle((int)(CoordenadaX - Radio / 2), (int)(CoordenadaY - Radio / 2), Radio, Radio);
            if (valor == dato)
            {
                grafo.FillEllipse(encuentro, rect);
            }
            else
            {
                grafo.FillEllipse(encuentro, rect);
                grafo.FillEllipse(Relleno, rect);
            }
            grafo.DrawEllipse(Lapiz, rect);
            //Pasando de Int a String gracias a ASCII
            char s = (char)(valor);
            //Dibujar el valor del nodo
            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;
            grafo.DrawString(s.ToString(), fuente, Brushes.Black, CoordenadaX, CoordenadaY, formato);

            //Dibuja los nodos hijos derecho e izquierdo

            if (NodoIzquierdo != null)
            {
                NodoIzquierdo.DibujarNodo(grafo, fuente, Brushes.YellowGreen, RellenoFuente, Lapiz, dato, encuentro);
            }
            if (NodoDerecho != null)
            {
                NodoDerecho.DibujarNodo(grafo, fuente, Brushes.Yellow, RellenoFuente, Lapiz, dato, encuentro);
            }
        }
    }
}
