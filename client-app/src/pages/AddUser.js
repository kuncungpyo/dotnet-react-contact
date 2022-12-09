import UserForm from "../components/UserForm";
import UserApi from "../api/UserApi";

const AddUser = () => {
    const iniUser = {
        id: "",
        name: "",
        address: "",
        phone: "",
        email: "",
        avatarUrl: ""
      };

    async function addUser(user) {
        const response = await UserApi.addUser(user);
        if (response) {
            window.location.href = '/';
        }
    }

    return (
        <div>
            <UserForm onSubmit={addUser} user={iniUser} />
        </div>
    )
}

export default AddUser;