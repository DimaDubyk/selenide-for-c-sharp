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
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class SelenideElementListIterator : global::com.codeborne.selenide.impl.SelenideElementIterator {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_add0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_set1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_hasPrevious2;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_nextIndex3;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_previous4;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_previousIndex5;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_add6;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_set7;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorSelenideElementListIterator8;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/util/ListIterator;)V")]
        public SelenideElementListIterator(global::java.util.Iterator par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.NewObject(global::com.codeborne.selenide.impl.SelenideElementListIterator.staticClass, global::com.codeborne.selenide.impl.SelenideElementListIterator.j4n__ctorSelenideElementListIterator8, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.util.Iterator>(@__env, par0));
            }
        }
        
        protected SelenideElementListIterator(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public static global::java.lang.Class _class {
            get {
                return global::com.codeborne.selenide.impl.SelenideElementListIterator.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::com.codeborne.selenide.impl.SelenideElementListIterator.staticClass = @__class;
            global::com.codeborne.selenide.impl.SelenideElementListIterator.j4n_add0 = @__env.GetMethodID(global::com.codeborne.selenide.impl.SelenideElementListIterator.staticClass, "add", "(Ljava/lang/Object;)V");
            global::com.codeborne.selenide.impl.SelenideElementListIterator.j4n_set1 = @__env.GetMethodID(global::com.codeborne.selenide.impl.SelenideElementListIterator.staticClass, "set", "(Ljava/lang/Object;)V");
            global::com.codeborne.selenide.impl.SelenideElementListIterator.j4n_hasPrevious2 = @__env.GetMethodID(global::com.codeborne.selenide.impl.SelenideElementListIterator.staticClass, "hasPrevious", "()Z");
            global::com.codeborne.selenide.impl.SelenideElementListIterator.j4n_nextIndex3 = @__env.GetMethodID(global::com.codeborne.selenide.impl.SelenideElementListIterator.staticClass, "nextIndex", "()I");
            global::com.codeborne.selenide.impl.SelenideElementListIterator.j4n_previous4 = @__env.GetMethodID(global::com.codeborne.selenide.impl.SelenideElementListIterator.staticClass, "previous", "()Ljava/lang/Object;");
            global::com.codeborne.selenide.impl.SelenideElementListIterator.j4n_previousIndex5 = @__env.GetMethodID(global::com.codeborne.selenide.impl.SelenideElementListIterator.staticClass, "previousIndex", "()I");
            global::com.codeborne.selenide.impl.SelenideElementListIterator.j4n_add6 = @__env.GetMethodID(global::com.codeborne.selenide.impl.SelenideElementListIterator.staticClass, "add", "(Lcom/codeborne/selenide/SelenideElement;)V");
            global::com.codeborne.selenide.impl.SelenideElementListIterator.j4n_set7 = @__env.GetMethodID(global::com.codeborne.selenide.impl.SelenideElementListIterator.staticClass, "set", "(Lcom/codeborne/selenide/SelenideElement;)V");
            global::com.codeborne.selenide.impl.SelenideElementListIterator.j4n__ctorSelenideElementListIterator8 = @__env.GetMethodID(global::com.codeborne.selenide.impl.SelenideElementListIterator.staticClass, "<init>", "(Ljava/util/ListIterator;)V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)V")]
        public virtual void add(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::com.codeborne.selenide.impl.SelenideElementListIterator.j4n_add0, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)V")]
        public virtual void set(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::com.codeborne.selenide.impl.SelenideElementListIterator.j4n_set1, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool hasPrevious() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::com.codeborne.selenide.impl.SelenideElementListIterator.j4n_hasPrevious2)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int nextIndex() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((int)(@__env.CallIntMethod(this, global::com.codeborne.selenide.impl.SelenideElementListIterator.j4n_nextIndex3)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Object;")]
        public virtual global::java.lang.Object previous() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::com.codeborne.selenide.impl.SelenideElementListIterator.j4n_previous4));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int previousIndex() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((int)(@__env.CallIntMethod(this, global::com.codeborne.selenide.impl.SelenideElementListIterator.j4n_previousIndex5)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lcom/codeborne/selenide/SelenideElement;)V")]
        public virtual void add(global::com.codeborne.selenide.SelenideElement par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::com.codeborne.selenide.impl.SelenideElementListIterator.j4n_add6, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::com.codeborne.selenide.SelenideElement>(@__env, par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lcom/codeborne/selenide/SelenideElement;)V")]
        public virtual void set(global::com.codeborne.selenide.SelenideElement par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::com.codeborne.selenide.impl.SelenideElementListIterator.j4n_set7, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::com.codeborne.selenide.SelenideElement>(@__env, par0));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::com.codeborne.selenide.impl.SelenideElementListIterator(@__env);
            }
        }
    }
    #endregion
}