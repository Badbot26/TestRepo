using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SolidPrinciples.InterfaceSegregation
{
    public static class Engine
    {
        public class Document
        {

        }

        public interface IMachine
        {
            void Print(Document d);
            void Scan(Document d);
            void Fax(Document d);
        }

        public class MultiFunctionPrinter : IMachine
        {
            public void Fax(Document d)
            {
                //
            }

            public void Print(Document d)
            {
                //
            }

            public void Scan(Document d)
            {
                //
            }
        }

        public class OldFashionedPrinter : IMachine
        {
            public void Fax(Document d)
            {
                //
            }

            public void Print(Document d)
            {
                throw new NotImplementedException();
            }

            public void Scan(Document d)
            {
                throw new NotImplementedException();
            }
        }

        public interface IPrinter
        {
            void Print(Document d);
        }

        public interface IScanner
        {
            void Scan(Document d);
        }

        public interface IFaxer
        {
            void Fax(Document d);
        }

        public class Photocopier : IPrinter, IScanner
        {
            public void Print(Document d)
            {
                //
            }

            public void Scan(Document d)
            {
                //
            }
        }

        public interface IMultiFunction: IPrinter, IScanner, IFaxer
        {

        }

        public class MultiFunctionMachine : IMultiFunction
        {
            private IPrinter printer;
            private IScanner scanner;
            private IFaxer faxer;

            public MultiFunctionMachine(IPrinter printer, IScanner scanner, IFaxer faxer)
            {
                this.printer = printer;
                this.scanner = scanner;
                this.faxer = faxer;
            }

            // these below are actually the decorator pattern

            public void Fax(Document d)
            {
                faxer.Fax(d);
            }

            public void Print(Document d)
            {
                printer.Print(d);
            }

            public void Scan(Document d)
            {
                scanner.Scan(d);
            }
        }

        public static void Run()
        {
            /*
             * The interface segregation principle means we should keep our interfaces as small as possible
             * We should not create very large interfaces
             * Anybody that implements our interface, should not be creating methods that they do not actually need
             * Look to have more atomic interfaces
             */

            // for now, there is no logic to execute in this engine
        }
    }
}