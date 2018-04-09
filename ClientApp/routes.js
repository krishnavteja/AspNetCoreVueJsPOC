import CounterExample from 'components/counter-example'
import FetchData from 'components/fetch-data'
import Users from 'components/users'
import HomePage from 'components/home-page'
import User from 'components/user'

export const routes = [
    { path: '/', component: HomePage, display: 'Home', style: 'glyphicon glyphicon-home' },
    { path: '/users', component: Users, display: 'Users', style: 'glyphicon glyphicon-user' },
    { path: '/roles', component: FetchData, display: 'Roles', style: 'glyphicon glyphicon-th-list' },
    { name: 'newuser', path: '/user', component: User },
    { name: 'edituser', path: '/user/:id', component: User }
]
