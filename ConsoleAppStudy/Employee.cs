using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStudy
{

    // < classModifier > --> public متاح , internal (default) متاح ضمن قيود معينه 
    // <classModifier> class <className> 
    //{
    //      class block --> i can put ( fields , constants , proprities , Method , Events, operstors , indexers , constructors, finalizers, Nested Types }
    //}

     class Employee
    {


        // <AccessModifier> ----->  public , private , protected

        // constant  ----->   <AccessModifier> const  <DataType>   <constantName>  = <Value>;
        public const double TAX = 0.03;

        // Feilds ----->   <AccessModifier>   <DataType>   <FieldName>  = <InitialValue>;

        //
        public string fname;
        public string lname;
        public double wage;
        public double loggedhours ;



    }
}
