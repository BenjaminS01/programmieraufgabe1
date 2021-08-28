function getWeatherByPlaceName(){
    var requestedCity=$("#placeName").val();
        $.ajax ({
            url: "https://localhost:44380/place/"+requestedCity,
            headers: {
                'Access-Control-Allow-Credentials' : true,
                'Access-Control-Allow-Origin': 'https://localhost:44380',
                'Access-Control-Allow-Methods':'GET',
                'Access-Control-Allow-Headers':'application/json',
	            'Content-Type': 'application/x-www-form-urlencoded',
	            'Accept': '*'
            },
            success: function(data) {
                setTextfields(data);
            },
            error: function()
                {
                    alert("Kein Eintrag gefunden. Bitte überprüfen Sie Ihre Eingabe.");
                }
            });
    };

    function getWeatherByLatLon(){
        var latitude=$("#latitude").val();
        var longitude=$("#longitude").val();

            $.ajax ({
                url: "https://localhost:44380/coord/"+latitude+"/"+longitude,
                headers: {
                    'Access-Control-Allow-Credentials' : true,
                    'Access-Control-Allow-Origin': 'https://localhost:44380',
                    'Access-Control-Allow-Methods':'GET',
                    'Access-Control-Allow-Headers':'application/json',
                    'Content-Type': 'application/x-www-form-urlencoded',
                    'Accept': '*'
                },
                success: function(data) {
                    setTextfields(data);
                },
                error: function()
                    {
                        alert("Kein Eintrag gefunden. Bitte überprüfen Sie Ihre Eingabe.");
                    }
                });
        };

    function setTextfields(data){
        $("#city").html("Aktuelle Wetterlage in "+data.name+", "+data.country);

        $("#temperatur").html(data.main.temp + "°C");
        $("#luftdruck").html(data.main.pressure + " hPa");
        $("#feuchtigkeit").html(data.main.humidity + "%");
        $("#geringsteTemp").html(data.main.temp_min + "°C");
        $("#höchsteTemp").html(data.main.temp_max + "°C");
        $("#windgeschw").html(data.wind.speed + " m/s");
        $("#windr").html(data.wind.deg + "°");
        $("#icon").attr("src", data.weather[0].icon);
        $("#beschreibung").html(data.weather[0].description);

        $(".weather").css("display", "block");
    };

   function searchByPlaceName(){
        $("#searchByPlaceName").css("display", "flex");
        $("#searchByLatLon").css("display", "none");
        $("#searchLabel").html("Stadtname eingeben");
    };

   function searchByLatLon(){
    navigator.geolocation.getCurrentPosition(function(location) {
        $("#latitude").val(location.coords.latitude);
        $("#longitude").val(location.coords.longitude);
      });
        $("#searchByLatLon").css("display", "flex");
        $("#searchByPlaceName").css("display", "none");
        $("#searchLabel").html("Längen- und Breitengrad Bestätigen");
    };


