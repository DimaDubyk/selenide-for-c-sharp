// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package com.codeborne.selenide;

@net.sf.jni4net.attributes.ClrTypeInfo
public final class WebDriverProvider_ {
    
    //<generated-static>
    private static system.Type staticType;
    
    public static system.Type typeof() {
        return com.codeborne.selenide.WebDriverProvider_.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        com.codeborne.selenide.WebDriverProvider_.staticType = staticType;
    }
    //</generated-static>
}

//<generated-proxy>
@net.sf.jni4net.attributes.ClrProxy
class __WebDriverProvider extends system.Object implements com.codeborne.selenide.WebDriverProvider {
    
    protected __WebDriverProvider(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/Object;)Ljava/lang/Object;")
    public native org.openqa.selenium.WebDriver createDriver(org.openqa.selenium.remote.DesiredCapabilities par0);
}
//</generated-proxy>