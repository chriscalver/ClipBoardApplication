fetch("https://fia-formula-1-championship-statistics.p.rapidapi.com/api/standings/drivers-standings?year=2023", {
	"method": "GET",
	headers: {
		'X-RapidAPI-Key': '78f85b7b41msh23461f7d0f97e63p1b3ddajsna0629e398be9',
		'X-RapidAPI-Host': 'fia-formula-1-championship-statistics.p.rapidapi.com'
	}
})
.then(response => response.json())
.then(response => {
  console.log(response);
  //console.log(response.content);
  // let str = "12345.00";
//str = str.slice(0, -1); 
//console.log(str);
//response.driverStandings[0].pts + " " + "-" + " " + 
    
 document.getElementById('d1').innerHTML = response.driverStandings[0].driver.firstname + " " + response.driverStandings[0].driver.lastname.slice(0, -4);
 document.getElementById('team').innerHTML = response.driverStandings[0].car.slice(0, 3);;
 document.getElementById('pts').innerHTML = response.driverStandings[0].pts;
 document.getElementById('country').innerHTML = response.driverStandings[0].nationality;
 
 
 document.getElementById('d2').innerHTML = response.driverStandings[1].driver.firstname + " " + response.driverStandings[1].driver.lastname.slice(0, -4);
 document.getElementById('d3').innerHTML = response.driverStandings[2].driver.firstname + " " + response.driverStandings[2].driver.lastname.slice(0, -4);
 document.getElementById('d4').innerHTML = response.driverStandings[3].driver.firstname + " " + response.driverStandings[3].driver.lastname.slice(0, -4);
 document.getElementById('d5').innerHTML = response.driverStandings[4].driver.firstname + " " + response.driverStandings[4].driver.lastname.slice(0, -4);




// document.getElementById('box2').innerHTML = response[0].name;
})
.catch(err => {
	console.log(err);
});


function addTable() {
	
	var myTableDiv = document.getElementById("myDynamicTable");

	var table = document.createElement('TABLE');
	table.border = '1';
	table.align="center";

	var tableBody = document.createElement('TBODY');
	table.appendChild(tableBody);

	for (var i = 0; i < 20; i++) {    //this sets number of rows 20
	  var tr = document.createElement('TR');
	  tableBody.appendChild(tr);

	  for (var j = 0; j < 1; j++) {   //this sets number of columns 1
		//var driverName = ;
		var tdPosition = document.createElement('TD');
		tdPosition.width = '20';
		tdPosition.appendChild(document.createTextNode("" + i + "," + j));
		tr.appendChild(tdPosition);

		var tdPosition2 = document.createElement('TD');
		tdPosition2.width = '220';
		tdPosition2.appendChild(document.createTextNode(i));
		tr.appendChild(tdPosition2);

		var tdPosition3 = document.createElement('TD');
		tdPosition3.width = '50';
		tdPosition3.appendChild(document.createTextNode("" + i + "," + j));
		tr.appendChild(tdPosition3);

		var tdPosition4 = document.createElement('TD');
		tdPosition4.width = '20';
		tdPosition4.appendChild(document.createTextNode("" + i + "," + j));
		tr.appendChild(tdPosition4);

		var tdPosition5 = document.createElement('TD');
		tdPosition5.width = '100';
		tdPosition5.appendChild(document.createTextNode("" + i + "," + j));
		tr.appendChild(tdPosition5);

	  }
	}
	myTableDiv.appendChild(table);
}
addTable();

