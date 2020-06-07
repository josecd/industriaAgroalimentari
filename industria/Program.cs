using System;

namespace industria
{
    class Program
    {
        static void Main(string[] args)
        {
            Fresh productFresh = new Fresh();
            productFresh.typeProduct = "Producto fresco";
            productFresh.expDate = "20/01/2010";
            productFresh.lotNum = 2;
            productFresh.packDate = "19/01/2009";
            productFresh.countOrigin = "MX";
            productFresh.productFresh();

            Refrigerated productRefrigerated = new Refrigerated();
            productRefrigerated.typeProduct = "Producto refrigerado";
            productRefrigerated.expDate = "20/01/2010";
            productRefrigerated.lotNum = 2;
            productRefrigerated.packDate = "19/01/2009";
            productRefrigerated.countOrigin = "MX";
            productRefrigerated.temp = 2.0;
            productRefrigerated.orgCode = 222;
            productRefrigerated.productRefrigerated();


            Frozen productFrozen = new Frozen();
            productFrozen.typeProduct = "Producto congelado";
            productFrozen.expDate = "20/01/2010";
            productFrozen.lotNum = 2;
            productFrozen.packDate = "19/01/2009";
            productFrozen.countOrigin = "MX";
            productFrozen.temp = 2.0;
            Fwater fwater = new Fwater();
            productFrozen.productFrozen();
            fwater.productFwater(2.0);


            Frozen productFrozen2 = new Frozen();
            productFrozen2.typeProduct = "Producto congelado";
            productFrozen2.expDate = "20/01/2010";
            productFrozen2.lotNum = 2;
            productFrozen2.packDate = "19/01/2009";
            productFrozen2.countOrigin = "MX";
            productFrozen2.temp = 2.0;
            Fnitrogen fnitro = new Fnitrogen();
            productFrozen2.productFrozen();
            fnitro.productFnitrogen("camara de congelacion", 1.0);


            Frozen productFrozen3 = new Frozen();
            productFrozen3.typeProduct = "Producto congelado";
            productFrozen3.expDate = "20/01/2010";
            productFrozen3.lotNum = 2;
            productFrozen3.packDate = "19/01/2009";
            productFrozen3.countOrigin = "MX";
            productFrozen3.temp = 2.0;
            FAir fAir = new FAir();
            productFrozen3.productFrozen();
            fAir.productFair(1.0,2.0,3.0,10.0);

        }
    }

    class Products  
    {
        public string expDate { get; set; }
        public int lotNum { get; set; }
        public string packDate { get; set; }
        public string countOrigin { get; set; }
        public string typeProduct { get; set; }

    }

    class Fresh : Products
    {
        public void productFresh()
        {
            Console.WriteLine(
                                "Tipo de producto: " + typeProduct + "\n" +
                                "La fecha de expiracion es: " + expDate + "\n"+
                               "La numero de lote : " + lotNum + "\n" +
                               "Fecha de empaquetado : " + packDate + "\n"+
                               "Pais de origen : " + countOrigin + "\n"
                               );
        }

    }
    
    class Frozen : Products
    {
 

        public double temp { get; set; }
        public void productFrozen()
        {
            Console.WriteLine(
                               "Tipo de producto: " + typeProduct + "\n" +
                               "La fecha de expiracion es: " + expDate + "\n" +
                               "La numero de lote : " + lotNum + "\n" +
                               "Fecha de empaquetado : " + packDate + "\n" +
                               "Pais de origen : " + countOrigin + "\n" +
                               "Fecha de envazado : " + temp + "\n"
                               );

        }

    }
    class Fwater : Frozen
    {
        public double salinity { get; set; }

        public void productFwater(double salinid)
        {
            Console.WriteLine(
                               "-----Congelado por agua----"   + "\n" +

                               "Salinidad del agua: " + salinid + "gr/Lt \n"
                               );
        }

    }

    class Fnitrogen : Frozen
    {
        public string methodUsed { get; set; }

        public double expoTime { get; set; }

        public void productFnitrogen(string method, double expo)
        {
            Console.WriteLine(
                               "-----Congelado por nitrogeno----" + "\n" +

                               "Metodo de congelacion: " + method + "\n"+
                               "Tiempo de exposicion al nitrogeno: " + expo + "s \n"
                               );
        }
    }

    class FAir : Frozen
    {
        public double perNitro { get; set; }
        public double perVapor { get; set; }
        public double perOxigen { get; set; }
        public double perCo2 { get; set; }

        public void productFair(double nitro, double vapor,double oxigen,double co2)
        {
            Console.WriteLine(
                               "-----Congelado por aire----" + "\n" +

                               "Composicion del aire: " + " \n" +
                               "Nitrogeno: " + nitro + "% \n"+
                               "Vapor: " + vapor + "% \n"+
                               "Oxigeno: " + oxigen + "% \n" +
                               "Co2: " + co2 + "% \n" 
                               );
        }
    }
    class Refrigerated :Products
    {
        public double temp { get; set; }
        public int orgCode { get; set; }

        public void productRefrigerated()
        {
            Console.WriteLine(
                               "Tipo de producto: " + typeProduct + "\n" +
                               "La fecha de expiracion es: " + expDate + "\n" +
                               "La numero de lote : " + lotNum + "\n" +
                               "Fecha de empaquetado : " + packDate + "\n" +
                               "Pais de origen : " + countOrigin + "\n" +
                               "Fecha de envazado : " + temp + "\n"+
                                "Codigo de organismo : " + orgCode + "\n"
                               );

        }

    }


}
