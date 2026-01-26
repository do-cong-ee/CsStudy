using System;
using System.Dynamic;
using System.Reflection;
using System.Reflection.Emit;

namespace EmitTest
{
    public class MainApp
    {
        public static void Main(string[] args)
        {
            AssemblyBuilder newAssembly =
                AssemblyBuilder.DefineDynamicAssembly(
                    new AssemblyName("CalculatorAssembly"),
                    AssemblyBuilderAccess.Run); // 어샘블리 생성 -> 이제 모듈 생성할차례

            ModuleBuilder newModule = newAssembly.DefineDynamicModule("Calculator"); // 모듈 -> 이제 class 타입 생성할차례

            TypeBuilder newType = newModule.DefineType("Sum1To100"); //class -> 이제 메소드 생성할 차례

            MethodBuilder newMethod = newType.DefineMethod("Calculate",MethodAttributes.Public,typeof(int),new Type[0]);

            ILGenerator generator = newMethod.GetILGenerator(); //IL 명령어 생성기 

            generator.Emit(OpCodes.Ldc_I4, 1);

            for(int i=2;i<=100;i++)
            {
                generator.Emit(OpCodes.Ldc_I4, i);
                generator.Emit(OpCodes.Add);
            }

            generator.Emit(OpCodes.Ret); //반환 
            newType.CreateType(); //작성을 다함 

            object sum1To100 = Activator.CreateInstance(newType);
            Type sumType = sum1To100.GetType();
            MethodInfo calculateMethod = sumType.GetMethod("Calculate");
            Console.WriteLine(calculateMethod.Invoke(sum1To100, null));
        }
    }
}