import { useEffect, useState } from 'react';
import { Button, Col, Row } from 'reactstrap';
import UserCard from '../components/UserCard';
import UserApi from '../api/UserApi';
import { Link } from 'react-router-dom';

const UserList = () => {
    const [users, setUsers] = useState([]);

    useEffect(() => {
        async function initUsers() {
            const initUsers = await UserApi.fetchAllUsers();
            setUsers(initUsers)
        }

        initUsers();
    },[]);

    return (
        <>
            <Row>
            {   
                users && users.map((user, index) => 
                    <UserCard key={index} user={user}/>
                )   
            }
            </Row>
            <Row className="m-t-15 m-b-15">
                <Col>
                    <Link to={`/user/add`}>
                        <Button color="primary">
                            Add User
                        </Button>
                    </Link>              
                </Col>
            </Row>
        </>
    );
}

export default UserList;