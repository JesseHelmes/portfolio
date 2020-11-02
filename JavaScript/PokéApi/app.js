$(document).ready(function(){

	const pokedexContainer = document.querySelector('#pokedex-container');
	const regions = document.querySelector('#regions');
	const pokedexPokemonContainer = document.querySelector('#pokedex-pokemon-container');
	
	const logo = document.querySelector('#logo');

	const baseApi = "https://pokeapi.co/api/v2/";
	const baseImageUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/";

	let lastPokémonId = 807;
	let searchedForText;
	let pokedexData = [];

	/*
	https://pokeapi.co/
	file:///C:/Users/jesse/Documents/school%20graafschapcollege/JavaScript/Pok%C3%A9Api/index.html
	ToDo
	lightbox als je op pokemon click komt info en achtergrond wordt donker
	klik je op donker scherm dan verdwijnt het
	https://webdesign.tutsplus.com/articles/super-simple-lightbox-with-css-and-jquery--webdesign-3528


	kijk of je css kan krijgen van docent

	bij volgende en vorige
	moet naam nog doen

	giratina underworld en overworld waar zijn die?
	487-altered.png

	afbeelding klik draaid pokemon
	knop veranderd naar shiny

	Build a Pokedex with Vanilla HTML, CSS, and JavaScript
	https://www.youtube.com/watch?v=T-VQUKeSU1w&feature=emb_rel_pause

	Fun With API's - Pokedex (Using React)
	https://www.youtube.com/watch?v=XehSJF85F38
	*/

   $(document).ready(function(){
	   //maakt de region menu aan
		$.ajax({
			url: baseApi + 'region'
		}).done(setRegions);

		//pakt de pokemons van de eerste region
		$.ajax({
			url: baseApi + 'region/' + 1
		}).done(handleRegion);

		$.ajax({
			url: baseApi + 'pokemon'
		}).done(setMaxPokemonId);

		//getPokemonDetails(153);
   });

   function setRegions(data){
		console.log('the Regions request has finished!');
		for(var i = 0; i < data.count; i++){
			regions.innerHTML += "<li><a href='#'>" + data.results[i].name +"</a></li>";
		}
	}

	function setMaxPokemonId(data){
		lastPokémonId = data.count;
	}

	$(regions).on('click', 'li a', function(e){
		e.preventDefault();
		pokedexContainer.innerHTML = '';
		searchedForText = $(this).first().parent().text().toLowerCase();
		//laad alle pokémons van de gekozen region
		$.ajax({
			url: baseApi + 'region/' + searchedForText
		}).done(handleRegion);
	});

	//dit is traag
	//laad alle pokémons van de region
	function handleRegion(data){
		count = data.pokedexes.length;
		for(var i = 0; i < count; i++){
			$.ajax({
				url: data.pokedexes[i].url
			}).done(getRegionPokemons);
		}

		/*pokedexData = [];
		for(var i = 0; i < count; i++){
			$.ajax({
				url: data.pokedexes[i].url
			}).done(pokedexFill);
		}*/

		//pokedexData['pokemon_entries'] = getUnique(pokedexData);
		//getRegionPokemons(pokedexData);

		//op gen
		/*$.ajax({
			url: data.main_generation.url
		}).done(getGenPokemons);*/
	}

	//probeerde duplicaties te verkomen
	function pokedexFill(data){
		console.log(data);
		count = data.pokemon_entries.length;
		for(var i = 0; i < count; i++){
			pokedexData.push(data.pokemon_entries[i]);
		}
		console.log(pokedexData);
		//pokedexData['pokemon_entries'] = getUnique(pokedexData);
		//getRegionPokemons(pokedexData);
	}

	// Defining function to get unique values from an array
	function getUnique(array){
		var uniqueArray = [];
		//console.log(array);

		// Loop through array values
		for(var value of array){
			if(uniqueArray.indexOf(value.pokemon_species) === -1){
				uniqueArray.push(value);
			}
		}
		return uniqueArray;
	}

	/*function getGenPokemons(data){
		count = data.pokemon_species.length;
		for(var i = 0; i < count; i++){

			pokemon = data.pokemon_species[i];
			pokemon_id = pokemon.url.replace(baseApi + "pokemon-species/", "").replace("/", "");

			pokedexContainer.innerHTML += "<div id='region-pokemon' pokemon-id='"+pokemon_id+"'>"+
			"<a href='#'><img src='"+ getPokemonFrontImage(pokemon_id) +"'>"+
			"</a><p>"+pokemon_id+". "+pokemon.name+"</p></div>";
		}
	}*/

	function getRegionPokemons(data){
		//console.log(data);
		count = data.pokemon_entries.length;
		for(var i = 0; i < count; i++){
			//hoe verkom ik dat je dubbel pokemons krijgt voor een region?
			pokemon = data.pokemon_entries[i].pokemon_species;
			pokemon_id = pokemon.url.replace(baseApi + "pokemon-species/", "").replace("/", "");

			pokedexContainer.innerHTML += "<div id='region-pokemon' pokemon-id='"+pokemon_id+"'>"+
			"<a href='#'><img src='"+ getPokemonFrontImage(pokemon_id) +"'>"+
			"</a><p>"+pokemon_id+". "+pokemon.name+"</p></div>";
		}
	}

	//region menu click event
	$(pokedexContainer).on('click', '#region-pokemon a', function(e){
		e.preventDefault();
		pokemon_id = $(this).parent().attr('pokemon-id');
		$('#lightbox').show();
		$(pokedexPokemonContainer).show();
		getPokemonDetails(pokemon_id);
	});

	//volgende vorige navigatie in pokemon details
	$(pokedexPokemonContainer).on('click', '#navigator a', function(e){
		e.preventDefault();
		pokemon_id = $(this).attr('pokemon-id');
		getPokemonDetails(pokemon_id);
	});

	//dit laad alle pokémon details van een pokémon
	function getPokemonDetails(pokemon_id){
		$.ajax({
			url: baseApi + 'pokemon/' + pokemon_id
		}).done(getPokemonInfo);

		$.ajax({
			url: baseApi + 'pokemon-species/' + pokemon_id
		}).done(getPokemonExtraInfo);
	}

	function getPokemonInfo(data){
		var types = "", abilities = "", base_stats = "";

		//previous
		if(data.id > 1){
			$('#previous-pokemon a').attr("pokemon-id", data.id - 1);
			$('#previous-pokemon a img').attr("src", getPokemonFrontImage(data.id - 1));
			$('#previous-pokemon p').text("#" + (data.id - 1) );
			$('#previous-pokemon').show();
		}else{
			 //hide als er geen vorige is
			$('#previous-pokemon').hide();
		}

		//next
		if(data.id < lastPokémonId){
		$('#next-pokemon a').attr("pokemon-id", data.id + 1);
		$('#next-pokemon a img').attr("src", getPokemonFrontImage(data.id + 1));
		$('#next-pokemon p').text("#" + (data.id + 1) );
		$('#next-pokemon').show();
		}else{
			 //hide als er geen volgende is
			$('#next-pokemon').hide();
		}

		//pokémon
		$('.pokémon-number').text("#" + data.id);
		$('.pokémon-name').text(data.name);
		$('.pokémon-image').attr("src", getPokemonFrontImage(data.id));

		//types
		for(var i = 0; i < data.types.length; i++){
			types += "<p class='pokémon-type "+data.types[i].type.name+"'>" + data.types[i].type.name + "</p>";
		}
		$('.pokémon-types').html(types);

		//abilities
		for(var i = 0; i < data.abilities.length; i++){
			abilities += "<p>" + data.abilities[i].ability.name + "</p>";
			//als het een hidden ablity is zorgt dit er voor dat het aangegeven wordt
			if(data.abilities[i].is_hidden){
				abilities += "<p id='hidden-abilty'>(Hidden Abilty)</p>";
			}
		}
		$('.pokémon-abilities').html(abilities);

		//stats
		for(var i = 0; i < data.stats.length; i++){
			stats = "";
			switch(data.stats[i].stat.name){
				case "attack":
					stats = "atk";
					break;
				case "defense":
					stats = "def";
					break;
				case "special-attack":
					stats = "sp.atk";
					break;
				case "special-defense":
					stats = "sp.def";
					break;
				default:
					stats = data.stats[i].stat.name;
					break;
			}
			base_stats += "<div class='"+ data.stats[i].stat.name +"' id='pokemon-details-Stats'><p>" + data.stats[i].base_stat + "</p><p>" + stats + "</p></div>";
		}
		$('.pokémon-stats').html(base_stats);
	}

	function getPokemonExtraInfo(data){
		$('.pokémon-specie').text(data.genera[7].genus);
	}

	//easter eggs
	$(logo).on('contextmenu', function(){
		$('#lightbox').show();
		$(pokedexPokemonContainer).show();
		id = Math.floor(Math.random() * lastPokémonId) + 1;
		getPokemonDetails(id);

		return false;
	});

	$(pokedexPokemonContainer).on('click', '#navigator #title', function(){
		id = Math.floor(Math.random() * lastPokémonId) + 1;
		getPokemonDetails(id);
	});

	//eind easter eggs

	//verander afbeelding naar shiny en terug
	$(pokedexPokemonContainer).on('click', '.pokémon-image', function(){
		pokemon_id = $('.pokémon-number').html().replace('#', '');
		isShiny = $(this).attr("src").includes('shiny');
		isBack = $(this).attr("src").includes('back');

		if(!isBack){
			if(!isShiny){
			$(this).attr("src", getShinyPokemonFrontImage(pokemon_id));
			}else{
				$(this).attr("src", getPokemonFrontImage(pokemon_id));
			}
		}else{
			if(!isShiny){
				$(this).attr("src", getShinyPokemonBackImage(pokemon_id));
				}else{
					$(this).attr("src", getPokemonBackImage(pokemon_id));
				}
		}
	});
	
	//recht klik om pokemon te draaien
	$(pokedexPokemonContainer).on('contextmenu', '.pokémon-image', function(){
		pokemon_id = $('.pokémon-number').html().replace('#', '');
		isShiny = $(this).attr("src").includes('shiny');
		isBack = $(this).attr("src").includes('back');

		if(isBack){
			if(isShiny){
			$(this).attr("src", getShinyPokemonFrontImage(pokemon_id));
			}else{
				$(this).attr("src", getPokemonFrontImage(pokemon_id));
			}
		}else{
			if(isShiny){
				$(this).attr("src", getShinyPokemonBackImage(pokemon_id));
				}else{
					$(this).attr("src", getPokemonBackImage(pokemon_id));
				}
		}
		return false;
	});

	//afbeeldingen Begin
	function getPokemonFrontImage(pokemon_id){
		return baseImageUrl +pokemon_id+".png";//?raw=true"
	}

	function getPokemonBackImage(pokemon_id){
		return baseImageUrl + "back/" +pokemon_id+".png";
	}

	function getShinyPokemonFrontImage(pokemon_id){
		return baseImageUrl + "shiny/"+pokemon_id+".png";
	}

	function getShinyPokemonBackImage(pokemon_id){
		return baseImageUrl + "back/shiny/"+pokemon_id+".png";
	}
	//afbeeldingen Einde

	//dit zorgt er voor dat de pokémon details word verborgen
	$('#lightbox').on('click', function(e){
		$(this).hide();
		$(pokedexPokemonContainer).hide();
	});
});
