	<template>
		<div>
https://github.com/ronanguilloux/php-gpio
php raspberry json led gpio
			temperature: {{temp.celsius}} °C
			CPU: {{temp_cpu.celsius}} °C

			<!-- temperature list -->
			<!--<table>
				<tr> <th>temperature</th> <th>tijd</th> <th>id</th> </tr>
				<tr v-for="temp in temperaturen">
					<td>{{temp.celsius}}</td>
					<td>{{temp.tijd}}</td>
					<td>{{temp.id}}</td>
				</tr>
			</<table>-->

		</div>
	</template>

<script>
	export default {
		data() {
			return {
				keywords: '',
				temp: [],
				temp_cpu: [],
				temperaturen: []
			};
		},
		mounted(){
			/*this.getTemperature();
			this.getTemperatureCPU();
			this.getTemperatureList();*/

			this.setData('temperature', this.temp);
			this.setData('temperature/cpu', this.temp_cpu);
			//this.setData('temperature', this.temperaturen);
		},
		methods: {
			/*getTemperature(){
				axios.get('/api/temperature')
					.then(response => this.temp = response.data)
					.catch(error => {});
			},
			getTemperatureCPU(){
				axios.get('/api/temperature/cpu')
					.then(response => this.temp_cpu = response.data)
					.catch(error => {});
			},
			getTemperatureList(){
				axios.get('/api/temperature')
					.then(response => this.temperaturen = response.data)
					.catch(error => {});
			},*/

			setData(api, data){
				axios.get('/api/' + api)
					.then(response => data = response.data)
					.catch(error => {});
			}
		},
		computed: {
			
		},
		ready: {
		//https://stackoverflow.com/questions/36572540/vue-js-auto-reload-refresh-data-with-timer
		//https://laracasts.com/discuss/channels/vue/how-to-periodically-poll-a-back-end-api-using-vuejs
			setInterval(this.getData('temperature', this.temp), 30000);
			setInterval(this.getData('temperature', this.temp_cpu), 30000);
		}
	}
</script>
