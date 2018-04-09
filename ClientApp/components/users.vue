<template>
    <div>
        <h2>
            <span>Users</span>
            <router-link class="btn btn-sm btn-success pull-right" :to="'/user'"><span class="glyphicon glyphicon-plus"></span> <span>Add New User</span></router-link>
        </h2>

        <p v-if="!users"><em>Loading...</em></p>
        <table class="table" v-if="users">
            <thead>
                <tr>
                    <th>First Name</th>
                    <th>Last Name</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="user in users">
                    <td>{{ user.firstName }}</td>
                    <td>{{ user.lastName }}</td>
                    <td>
                        <router-link class="btn btn-sm btn-primary" :to="{ name: 'edituser', params: { id: user.id }}">Select</router-link>
                    </td>
                </tr>
            </tbody>
        </table>

    </div>
</template>
<script>
    export default {
        data() {
            return {
                users: null
            }
        },

        methods: {
        },

        async created() {
            // ES2017 async/await syntax via babel-plugin-transform-async-to-generator
            // TypeScript can also transpile async/await down to ES5
            try {
                let response = await this.$http.get('/api/User')
                console.log(response.data);
                this.users = response.data;
            } catch (error) {
                console.log(error)
            }
            // Old promise-based approach
            //this.$http
            //    .get('/api/SampleData/WeatherForecasts')
            //    .then(response => {
            //        console.log(response.data)
            //        this.forecasts = response.data
            //    })
            //    .catch((error) => console.log(error))*/
        }
    }</script>
<style>
</style>
