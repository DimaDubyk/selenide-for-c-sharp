//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace com.codeborne.selenide.impl {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface WebElementsCollection {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        global::java.lang.String description();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/util/List;")]
        global::java.util.List getActualElements();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class WebElementsCollection_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::com.codeborne.selenide.impl.@__WebElementsCollection.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::com.codeborne.selenide.impl.WebElementsCollection), typeof(global::com.codeborne.selenide.impl.WebElementsCollection_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::com.codeborne.selenide.impl.WebElementsCollection), typeof(global::com.codeborne.selenide.impl.WebElementsCollection_))]
    internal sealed partial class @__WebElementsCollection : global::java.lang.Object, global::com.codeborne.selenide.impl.WebElementsCollection {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_description0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getActualElements1;
        
        private @__WebElementsCollection(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::com.codeborne.selenide.impl.@__WebElementsCollection.staticClass = @__class;
            global::com.codeborne.selenide.impl.@__WebElementsCollection.j4n_description0 = @__env.GetMethodID(global::com.codeborne.selenide.impl.@__WebElementsCollection.staticClass, "description", "()Ljava/lang/String;");
            global::com.codeborne.selenide.impl.@__WebElementsCollection.j4n_getActualElements1 = @__env.GetMethodID(global::com.codeborne.selenide.impl.@__WebElementsCollection.staticClass, "getActualElements", "()Ljava/util/List;");
        }
        
        public global::java.lang.String description() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::com.codeborne.selenide.impl.@__WebElementsCollection.j4n_description0));
            }
        }
        
        public global::java.util.List getActualElements() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::com.codeborne.selenide.impl.@__WebElementsCollection.j4n_getActualElements1));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__WebElementsCollection);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "description", "description0", "()Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getActualElements", "getActualElements1", "()Ljava/util/List;"));
            return methods;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle description0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/lang/String;
            // ()Ljava/lang/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::com.codeborne.selenide.impl.WebElementsCollection @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::com.codeborne.selenide.impl.WebElementsCollection>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongCp2J(@__real.description());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getActualElements1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/util/List;
            // ()Ljava/util/List;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::com.codeborne.selenide.impl.WebElementsCollection @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::com.codeborne.selenide.impl.WebElementsCollection>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.util.List>(@__env, @__real.getActualElements());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::com.codeborne.selenide.impl.@__WebElementsCollection(@__env);
            }
        }
    }
    #endregion
}