<<<<<<< HEAD
#pragma checksum "/Users/JB/Documents/codingDojo/projects/tourEZ/TourEZ/Views/Home/ViewEvent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1d9feb212abf4c53396756537c1d6a707491b8c"
=======
#pragma checksum "/Users/Shea/Desktop/TourEZ/Views/Home/ViewEvent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd55f356c8f2d369eadf7e592fb63c73277f2e58"
>>>>>>> cffb950da9d233a1b850151ffd650aa9153689e9
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
<<<<<<< HEAD
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1d9feb212abf4c53396756537c1d6a707491b8c", @"/Views/Home/ViewEvent.cshtml")]
=======
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd55f356c8f2d369eadf7e592fb63c73277f2e58", @"/Views/Home/ViewEvent.cshtml")]
>>>>>>> cffb950da9d233a1b850151ffd650aa9153689e9
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf93618951f8c8ed27964c10514889b319cd0c31", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewEvent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<viewEventVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
<<<<<<< HEAD
            BeginContext(19, 270, true);
            WriteLiteral(@"
    <div class=""jumbotron bg-dark"">
        <div class=""jumbotron bg-secondary border border-white"">
            <div id=""map"" class=""border border-white"" style=""height:300px; width:100%;""></div>
            <h1 class=""text-white""><span class=""text-dark"">EVENT:</span> ");
            EndContext();
            BeginContext(290, 25, false);
#line 6 "/Users/JB/Documents/codingDojo/projects/tourEZ/TourEZ/Views/Home/ViewEvent.cshtml"
                                                                    Write(Model.ThisEvent.eventName);
=======
            BeginContext(17, 254, true);
            WriteLiteral("\n<div class=\"jumbotron bg-dark\">\n    <div class=\"jumbotron bg-secondary border border-white\">\n        <div id=\"map\" class=\"border border-white\" style=\"height:300px; width:100%;\"></div>\n        <h1 class=\"text-white\"><span class=\"text-dark\">EVENT:</span> ");
            EndContext();
            BeginContext(272, 25, false);
#line 6 "/Users/Shea/Desktop/TourEZ/Views/Home/ViewEvent.cshtml"
                                                                Write(Model.ThisEvent.eventName);
>>>>>>> cffb950da9d233a1b850151ffd650aa9153689e9

#line default
#line hidden
            EndContext();
<<<<<<< HEAD
            BeginContext(315, 83, true);
            WriteLiteral(" </h1>\n            <h5 class=\"text-white\"><span class=\"text-dark\">LOCATION:</span> ");
            EndContext();
            BeginContext(399, 24, false);
#line 7 "/Users/JB/Documents/codingDojo/projects/tourEZ/TourEZ/Views/Home/ViewEvent.cshtml"
                                                                       Write(Model.ThisEvent.location);
=======
            BeginContext(297, 79, true);
            WriteLiteral(" </h1>\n        <h5 class=\"text-white\"><span class=\"text-dark\">LOCATION:</span> ");
            EndContext();
            BeginContext(377, 24, false);
#line 7 "/Users/Shea/Desktop/TourEZ/Views/Home/ViewEvent.cshtml"
                                                                   Write(Model.ThisEvent.location);
>>>>>>> cffb950da9d233a1b850151ffd650aa9153689e9

#line default
#line hidden
            EndContext();
<<<<<<< HEAD
            BeginContext(423, 84, true);
            WriteLiteral("</h5>\n            <h5 class=\"text-white\"><span class=\"text-dark\">START DATE:</span> ");
            EndContext();
            BeginContext(508, 55, false);
#line 8 "/Users/JB/Documents/codingDojo/projects/tourEZ/TourEZ/Views/Home/ViewEvent.cshtml"
                                                                         Write(Model.ThisEvent.startDate.ToString("dddd,dd MMMM yyyy"));
=======
            BeginContext(401, 80, true);
            WriteLiteral("</h5>\n        <h5 class=\"text-white\"><span class=\"text-dark\">START DATE:</span> ");
            EndContext();
            BeginContext(482, 55, false);
#line 8 "/Users/Shea/Desktop/TourEZ/Views/Home/ViewEvent.cshtml"
                                                                     Write(Model.ThisEvent.startDate.ToString("dddd,dd MMMM yyyy"));
>>>>>>> cffb950da9d233a1b850151ffd650aa9153689e9

#line default
#line hidden
            EndContext();
<<<<<<< HEAD
            BeginContext(563, 84, true);
            WriteLiteral("</h5>\n            <h5 class=\"text-white\"><span class=\"text-dark\">START TIME:</span> ");
            EndContext();
            BeginContext(648, 46, false);
#line 9 "/Users/JB/Documents/codingDojo/projects/tourEZ/TourEZ/Views/Home/ViewEvent.cshtml"
                                                                         Write(Model.ThisEvent.startTime.ToString("hh:mm tt"));
=======
            BeginContext(537, 80, true);
            WriteLiteral("</h5>\n        <h5 class=\"text-white\"><span class=\"text-dark\">START TIME:</span> ");
            EndContext();
            BeginContext(618, 46, false);
#line 9 "/Users/Shea/Desktop/TourEZ/Views/Home/ViewEvent.cshtml"
                                                                     Write(Model.ThisEvent.startTime.ToString("hh:mm tt"));
>>>>>>> cffb950da9d233a1b850151ffd650aa9153689e9

#line default
#line hidden
            EndContext();
<<<<<<< HEAD
            BeginContext(694, 82, true);
            WriteLiteral("</h5>\n            <h5 class=\"text-white\"><span class=\"text-dark\">END DATE:</span> ");
            EndContext();
            BeginContext(777, 53, false);
#line 10 "/Users/JB/Documents/codingDojo/projects/tourEZ/TourEZ/Views/Home/ViewEvent.cshtml"
                                                                       Write(Model.ThisEvent.endDate.ToString("dddd,dd MMMM yyyy"));
=======
            BeginContext(664, 78, true);
            WriteLiteral("</h5>\n        <h5 class=\"text-white\"><span class=\"text-dark\">END DATE:</span> ");
            EndContext();
            BeginContext(743, 53, false);
#line 10 "/Users/Shea/Desktop/TourEZ/Views/Home/ViewEvent.cshtml"
                                                                   Write(Model.ThisEvent.endDate.ToString("dddd,dd MMMM yyyy"));
>>>>>>> cffb950da9d233a1b850151ffd650aa9153689e9

#line default
#line hidden
            EndContext();
<<<<<<< HEAD
            BeginContext(830, 82, true);
            WriteLiteral("</h5>\n            <h5 class=\"text-white\"><span class=\"text-dark\">END TIME:</span> ");
            EndContext();
            BeginContext(913, 44, false);
#line 11 "/Users/JB/Documents/codingDojo/projects/tourEZ/TourEZ/Views/Home/ViewEvent.cshtml"
                                                                       Write(Model.ThisEvent.endTime.ToString("hh:mm tt"));
=======
            BeginContext(796, 78, true);
            WriteLiteral("</h5>\n        <h5 class=\"text-white\"><span class=\"text-dark\">END TIME:</span> ");
            EndContext();
            BeginContext(875, 44, false);
#line 11 "/Users/Shea/Desktop/TourEZ/Views/Home/ViewEvent.cshtml"
                                                                   Write(Model.ThisEvent.endTime.ToString("hh:mm tt"));
>>>>>>> cffb950da9d233a1b850151ffd650aa9153689e9

#line default
#line hidden
            EndContext();
<<<<<<< HEAD
            BeginContext(957, 127, true);
            WriteLiteral("</h5>\n        </div>\n    </div>\n\n\n<script>\n    function initMap() {\n        // The location of Uluru\n        var uluru = {lat: ");
            EndContext();
            BeginContext(1085, 34, false);
#line 19 "/Users/JB/Documents/codingDojo/projects/tourEZ/TourEZ/Views/Home/ViewEvent.cshtml"
                     Write(Model.ThisEvent.placeInfo.latitude);
=======
            BeginContext(919, 122, true);
            WriteLiteral("</h5>\n\n    </div>\n</div>\n\n\n<script>\n\n\n    function initMap() {\n        // The location of Uluru\n        var uluru = {lat: ");
            EndContext();
            BeginContext(1042, 24, false);
#line 22 "/Users/Shea/Desktop/TourEZ/Views/Home/ViewEvent.cshtml"
                     Write(Model.ThisEvent.latitude);
>>>>>>> cffb950da9d233a1b850151ffd650aa9153689e9

#line default
#line hidden
            EndContext();
<<<<<<< HEAD
            BeginContext(1119, 7, true);
            WriteLiteral(", lng: ");
            EndContext();
            BeginContext(1127, 35, false);
#line 19 "/Users/JB/Documents/codingDojo/projects/tourEZ/TourEZ/Views/Home/ViewEvent.cshtml"
                                                               Write(Model.ThisEvent.placeInfo.longitude);
=======
            BeginContext(1066, 7, true);
            WriteLiteral(", lng: ");
            EndContext();
            BeginContext(1074, 25, false);
#line 22 "/Users/Shea/Desktop/TourEZ/Views/Home/ViewEvent.cshtml"
                                                     Write(Model.ThisEvent.longitude);
>>>>>>> cffb950da9d233a1b850151ffd650aa9153689e9

#line default
#line hidden
            EndContext();
<<<<<<< HEAD
            BeginContext(1162, 3922, true);
=======
            BeginContext(1099, 3640, true);
>>>>>>> cffb950da9d233a1b850151ffd650aa9153689e9
            WriteLiteral(@"};
        // The map, centered at Uluru
        var map = new google.maps.Map(
            document.getElementById('map'), {
                zoom: 14,
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
                    {
                    featureType: 'poi.park',
                    elementType: 'geometry',
                    stylers: [{color: '#263c3f'}]
     ");
            WriteLiteral(@"               },
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
                    elementType: 'geometry',
                    stylers: [{color: '#746855'}]
                    },
                    {
                    featureType: 'road.highw");
            WriteLiteral(@"ay',
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
                    },
                    {
                    featureType: 'water',
                    elementType: 'labels.text.fill',
              ");
            WriteLiteral(@"      stylers: [{color: '#515c6d'}]
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
<<<<<<< HEAD
    <!--Load the API from the specified URL
    * The async attribute allows the browser to render the page while the API loads
    * The key parameter will contain your own API key (which is not needed for this tutorial)
    * The callback parameter executes the initMap() function
    -->
=======

>>>>>>> cffb950da9d233a1b850151ffd650aa9153689e9
<script async defer src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyDd0qpuCR49IQTA4Ce6wDEw5Gh5l10Swb8&callback=initMap""></script>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<viewEventVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
