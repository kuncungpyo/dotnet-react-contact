import config from '../config.json';

const UserApi = {

    fetchAllUsers: async() => await fetch(config.API_BASE_URL+"/users")
        .then(response => response.json())
        .then(jsondata => {
            return jsondata.value
        }),

    fetchUserById: async(id) => await fetch(`${config.API_BASE_URL}/user/${id}`)
        .then(response => response.json())
        .then(jsondata => {
            return jsondata.value
        }),

    editUser: async (user) => await fetch(config.API_BASE_URL+"/user", {
            method: 'put',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
              },
            body: JSON.stringify({
                "id": user.id,
                "name": user.name,
                "address": user.address,
                "phone": user.phone,
                "email": user.email,
                "avatarUrl": user.avatarUrl,
            })
        } )
        .then(response => response.json())
        .then(jsondata => {
            return jsondata.value
        })
        .catch((error) => {
            return error
        }),

    addUser: async (user) => await fetch(config.API_BASE_URL+"/user", {
            method: 'post',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
              },
            body: JSON.stringify({
                "name": user.name,
                "address": user.address,
                "phone": user.phone,
                "email": user.email,
                "avatarUrl": user.avatarUrl,
            })
        } )
        .then(response => response.json())
        .then(jsondata => {
            return jsondata.value
        })
        .catch((error) => {
            return error
        }),

    deleteUser: async (id) => await fetch(config.API_BASE_URL+"/user", {
            method: 'delete',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                "id": id,
            })
        })
}

export default UserApi;