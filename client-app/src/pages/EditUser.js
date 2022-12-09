import UserForm from "../components/UserForm";
import UserApi from "../api/UserApi";
import { useParams } from "react-router-dom";
import { useEffect, useState } from "react";

const EditUser = () => {
    const iniUser = {
        id: "",
        name: "",
        address: "",
        phone: "",
        email: "",
        avatarUrl: ""
      };

    const { id } = useParams();
    const [user, setUser] = useState(iniUser);

    useEffect(() => {
        async function getUser() {
            const userResponse = await UserApi.fetchUserById(id);
            setUser(userResponse)
        }

        getUser();
    },[]);

    async function editUser(user) {
        const response = await UserApi.editUser(user);
        if (response) {
            window.location.href = '/';
        }
    }

    async function deleteUser() {
        await UserApi.deleteUser(id);
        window.location.href = '/';
    }

    return (
        <div>
            <UserForm onSubmit={editUser} onDelete={deleteUser} user={user} />
        </div>
    )
}

export default EditUser;