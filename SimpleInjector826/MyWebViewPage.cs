using System.Web.Mvc;

namespace SimpleInjector826
{
    public abstract class MyWebViewPage : WebViewPage
    {
        [Import]
        public MyDependency MyDependency { get; set; }
    }

    public abstract class MyWebViewPage<T> : WebViewPage<T>
    {
        [Import]
        public MyDependency MyDependency { get; set; }
    }
}
