﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _04_ClientConsole.Calculator {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="", ConfigurationName="Calculator.ICalculator")]
    public interface ICalculator {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ICalculator/Add", ReplyAction="urn:ICalculator/AddResponse")]
        double Add(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ICalculator/Subtract", ReplyAction="urn:ICalculator/SubtractResponse")]
        double Subtract(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ICalculator/Multiply", ReplyAction="urn:ICalculator/MultiplyResponse")]
        double Multiply(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ICalculator/Divide", ReplyAction="urn:ICalculator/DivideResponse")]
        double Divide(double n1, double n2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorChannel : _04_ClientConsole.Calculator.ICalculator, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorClient : System.ServiceModel.ClientBase<_04_ClientConsole.Calculator.ICalculator>, _04_ClientConsole.Calculator.ICalculator {
        
        public CalculatorClient() {
        }
        
        public CalculatorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double Add(double n1, double n2) {
            return base.Channel.Add(n1, n2);
        }
        
        public double Subtract(double n1, double n2) {
            return base.Channel.Subtract(n1, n2);
        }
        
        public double Multiply(double n1, double n2) {
            return base.Channel.Multiply(n1, n2);
        }
        
        public double Divide(double n1, double n2) {
            return base.Channel.Divide(n1, n2);
        }
    }
}
