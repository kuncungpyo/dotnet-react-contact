import { Button, Card, CardText, CardTitle, Col, Row } from 'reactstrap';
import Avatar from 'react-avatar';
import { Link } from 'react-router-dom';

const UserCard = ({user}) => {
    return (
      <Col sm="4" style={{marginTop: '1em'}}>
        <Card body>
            <Row>
                <Col sm="4">
                    {!user.avatarUrl && <Avatar name={user.name} round />}
                    {user.avatarUrl && <Avatar name={user.name} src={user.avatarUrl} round />}
                </Col>
                <Col sm="8">
                    <CardTitle color='blue' tag="h5"> {user.name} </CardTitle>
                    <div> {user.email} </div>
                    <div> {user.phone} </div>
                    <div> {user.address} </div>
                    <div style={{marginTop: '1em'}}>
                        <Link to={`/user/edit/${user.id}`}>
                            <Button color="primary">
                                Edit
                            </Button>
                        </Link>
                    </div>
                </Col>
            </Row>
        </Card>
      </Col>
    )
}

export default UserCard;