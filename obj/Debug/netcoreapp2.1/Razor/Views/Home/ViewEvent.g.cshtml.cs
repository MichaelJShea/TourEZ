#pragma checksum "/Users/JB/Documents/codingDojo/projects/tourEZ/TourEZ/Views/Home/ViewEvent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81326b5e535f2c2422be06f0667eae8274388b91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewEvent), @"mvc.1.0.view", @"/Views/Home/ViewEvent.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ViewEvent.cshtml", typeof(AspNetCore.Views_Home_ViewEvent))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/JB/Documents/codingDojo/projects/tourEZ/TourEZ/Views/_ViewImports.cshtml"
using TourEZ;

#line default
#line hidden
#line 2 "/Users/JB/Documents/codingDojo/projects/tourEZ/TourEZ/Views/_ViewImports.cshtml"
using TourEZ.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81326b5e535f2c2422be06f0667eae8274388b91", @"/Views/Home/ViewEvent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf93618951f8c8ed27964c10514889b319cd0c31", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewEvent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(17, 270, true);
            WriteLiteral(@"
    <div class=""jumbotron bg-dark"">
        <div class=""jumbotron bg-secondary border border-white"">
            <div id=""map"" class=""border border-white"" style=""height:300px; width:100%;""></div>
            <h1 class=""text-white""><span class=""text-dark"">EVENT:</span> ");
            EndContext();
            BeginContext(288, 25, false);
#line 6 "/Users/JB/Documents/codingDojo/projects/tourEZ/TourEZ/Views/Home/ViewEvent.cshtml"
                                                                    Write(Model.ThisEvent.eventName);

#line default
#line hidden
            EndContext();
            BeginContext(313, 83, true);
            WriteLiteral(" </h1>\n            <h5 class=\"text-white\"><span class=\"text-dark\">LOCATION:</span> ");
            EndContext();
            BeginContext(397, 24, false);
#line 7 "/Users/JB/Documents/codingDojo/projects/tourEZ/TourEZ/Views/Home/ViewEvent.cshtml"
                                                                       Write(Model.ThisEvent.location);

#line default
#line hidden
            EndContext();
            BeginContext(421, 84, true);
            WriteLiteral("</h5>\n            <h5 class=\"text-white\"><span class=\"text-dark\">START DATE:</span> ");
            EndContext();
            BeginContext(506, 55, false);
#line 8 "/Users/JB/Documents/codingDojo/projects/tourEZ/TourEZ/Views/Home/ViewEvent.cshtml"
                                                                         Write(Model.ThisEvent.startDate.ToString("dddd,dd MMMM yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(561, 84, true);
            WriteLiteral("</h5>\n            <h5 class=\"text-white\"><span class=\"text-dark\">START TIME:</span> ");
            EndContext();
            BeginContext(646, 46, false);
#line 9 "/Users/JB/Documents/codingDojo/projects/tourEZ/TourEZ/Views/Home/ViewEvent.cshtml"
                                                                         Write(Model.ThisEvent.startTime.ToString("hh:mm tt"));

#line default
#line hidden
            EndContext();
            BeginContext(692, 82, true);
            WriteLiteral("</h5>\n            <h5 class=\"text-white\"><span class=\"text-dark\">END DATE:</span> ");
            EndContext();
            BeginContext(775, 53, false);
#line 10 "/Users/JB/Documents/codingDojo/projects/tourEZ/TourEZ/Views/Home/ViewEvent.cshtml"
                                                                       Write(Model.ThisEvent.endDate.ToString("dddd,dd MMMM yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(828, 82, true);
            WriteLiteral("</h5>\n            <h5 class=\"text-white\"><span class=\"text-dark\">END TIME:</span> ");
            EndContext();
            BeginContext(911, 44, false);
#line 11 "/Users/JB/Documents/codingDojo/projects/tourEZ/TourEZ/Views/Home/ViewEvent.cshtml"
                                                                       Write(Model.ThisEvent.endTime.ToString("hh:mm tt"));

#line default
#line hidden
            EndContext();
            BeginContext(955, 4082, true);
            WriteLiteral(@"</h5>
        </div>
    </div>


<script>
    function initMap() {
        // The location of Uluru
        var uluru = {lat: -25.344, lng: 131.036};
        // The map, centered at Uluru
        var map = new google.maps.Map(
            document.getElementById('map'), {
                zoom: 4,
                center: uluru,
                styles: [
                    {elementType: 'geometry', stylers: [{color: '#242f3e'}]},
                    {elementType: 'labels.text.stroke', stylers: [{color: '#242f3e'}]},
                    {elementType: 'labels.text.fill', stylers: [{color: '#746855'}]},
                    {
                    featureType: 'administrative.locality',
                    elementType: 'labels.text.fill',
                    stylers: [{color: '#d59563'}]
                    },
                    {
                    featureType: 'poi',
                    elementType: 'labels.text.fill',
                    stylers: [{color: '#d59563'}]
                    },
                    ");
            WriteLiteral(@"{
                    featureType: 'poi.park',
                    elementType: 'geometry',
                    stylers: [{color: '#263c3f'}]
                    },
                    {
                    featureType: 'poi.park',
                    elementType: 'labels.text.fill',
                    stylers: [{color: '#6b9a76'}]
                    },
                    {
                    featureType: 'road',
                    elementType: 'geometry',
                    stylers: [{color: '#38414e'}]
                    },
                    {
                    featureType: 'road',
                    elementType: 'geometry.stroke',
                    stylers: [{color: '#212a37'}]
                    },
                    {
                    featureType: 'road',
                    elementType: 'labels.text.fill',
                    stylers: [{color: '#9ca5b3'}]
                    },
                    {
                    featureType: 'road.highway',
                    elementType: 'geo");
            WriteLiteral(@"metry',
                    stylers: [{color: '#746855'}]
                    },
                    {
                    featureType: 'road.highway',
                    elementType: 'geometry.stroke',
                    stylers: [{color: '#1f2835'}]
                    },
                    {
                    featureType: 'road.highway',
                    elementType: 'labels.text.fill',
                    stylers: [{color: '#f3d19c'}]
                    },
                    {
                    featureType: 'transit',
                    elementType: 'geometry',
                    stylers: [{color: '#2f3948'}]
                    },
                    {
                    featureType: 'transit.station',
                    elementType: 'labels.text.fill',
                    stylers: [{color: '#d59563'}]
                    },
                    {
                    featureType: 'water',
                    elementType: 'geometry',
                    stylers: [{color: '#17263c'}]
       ");
            WriteLiteral(@"             },
                    {
                    featureType: 'water',
                    elementType: 'labels.text.fill',
                    stylers: [{color: '#515c6d'}]
                    },
                    {
                    featureType: 'water',
                    elementType: 'labels.text.stroke',
                    stylers: [{color: '#17263c'}]
                    }
                ]
            });
        // The marker, positioned at Uluru
        var marker = new google.maps.Marker({position: uluru, map: map});
        }
</script>
    <!--Load the API from the specified URL
    * The async attribute allows the browser to render the page while the API loads
    * The key parameter will contain your own API key (which is not needed for this tutorial)
    * The callback parameter executes the initMap() function
    -->
    <script async defer
    src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyDd0qpuCR49IQTA4Ce6wDEw5Gh5l10Swb8&callback=initMap"">
    </script>

");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
