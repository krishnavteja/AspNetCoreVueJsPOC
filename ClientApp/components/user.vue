<template>
    <div>
        <h2>
            <span v-if="user.id > 0">Edit User</span>
            <span v-else>New User</span>
            <router-link class="btn btn-sm btn-success pull-right" :to="'/users'"> <span class="glyphicon glyphicon-arrow-left"></span> <span>Go to Users</span></router-link>
        </h2>

        <div class="space-5"></div>

        <form class="form-horizontal">
            <div class="form-group">
                <label for="firstName" class="col-sm-2 control-label">First Name</label>
                <div class="col-sm-6">
                    <input class="form-control" v-model="user.firstName" placeholder="first name">
                </div>
            </div>
            <div class="form-group">
                <label for="lastName" class="col-sm-2 control-label">Last Name</label>
                <div class="col-sm-6">
                    <input class="form-control" v-model="user.lastName" placeholder="last name">
                </div>
            </div>
            <div class="form-group">
                <div class="col-sm-offset-2 col-sm-10">
                    <button type="button" v-on:click="saveUser" class="btn btn-primary">Save</button>
                </div>
            </div>
        </form>

    </div>
</template>
<script>
    export default {
        data() {
            return {
                user: {}
            }
        },

        methods: {
            saveUser: function (event) {
                alert(`Successfully saved user ${this.user.firstName} ${this.user.lastName}`);
            }
        },

        async created() {

            if (this.$route.params.id > 0) {
                // ES2017 async/await syntax via babel-plugin-transform-async-to-generator
                // TypeScript can also transpile async/await down to ES5
                try {
                    let response = await this.$http.get(`/api/User/${this.$route.params.id}`);
                    console.log(response.data);
                    this.user = response.data;
                } catch (error) {
                    console.log(error)
                }
            }
        }
    }
</script>
<style>
</style>
