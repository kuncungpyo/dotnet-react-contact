import { useEffect, useState } from "react";
import { Form, FormGroup, Label, Input, Button, Row, Col } from "reactstrap";

const UserForm = ({user, onSubmit, onDelete}) => {
    const initialFormData = Object.freeze(user);

    const [formData, updateFormData] = useState(initialFormData); 

    const handleChange = (e) => {
        updateFormData({
          ...formData,
          [e.target.name]: e.target.value.trim()
        });
      };

    const handleSubmitForm = (e) => {
        e.preventDefault();

        // replace with default if unchanged
        Object.keys(formData).forEach(key => {
            if (formData[key] === "") formData[key] = user[key];
        })    
        onSubmit(formData);
    };

    const handleDeleteUser = () => {
        onDelete();
    }
    
    return (
        <Form onSubmit={handleSubmitForm}>
            <Input id="id" name="id" type="hidden" value={initialFormData.id}/>
            <FormGroup>
                <Label for="name"> Name </Label>
                <Input id="name" name="name"
                    placeholder="John Doe"
                    defaultValue={initialFormData.name}
                    onChange={handleChange}
                />
            </FormGroup>
            <FormGroup>
                <Label for="email"> Email </Label>
                <Input id="email" name="email" 
                    placeholder="test@yahoo.com" 
                    type="email"
                    defaultValue={initialFormData.email}
                    onChange={handleChange}
                />
            </FormGroup>
            <FormGroup>
                <Label for="phone"> Phone </Label>
                <Input id="phone" name="phone" 
                    placeholder="0361234567"
                    defaultValue={initialFormData.phone}
                    onChange={handleChange}
                />
            </FormGroup>
            <FormGroup>
                <Label for="address"> Address </Label>
                <Input id="address" name="address" 
                    placeholder="Alabama Street"
                    defaultValue={initialFormData.address}
                    onChange={handleChange}
                />
            </FormGroup>
            <FormGroup>
                <Label for="avatarUrl"> Avatar Url </Label>
                <Input id="avatarUrl" name="avatarUrl" 
                    placeholder="http://example.com"
                    defaultValue={initialFormData.avatarUrl}
                    onChange={handleChange}
                />
            </FormGroup>
            <div className="centered">
                <Row className="m-t-10">
                    <Col md={user.id && 6 || 12}>
                        <Button type="submit" color="primary" className="full-width">
                            Submit
                        </Button>
                    </Col>
                    <Col md={6}>
                        {user.id &&  
                        <Button color="danger" className="full-width" onClick={handleDeleteUser} >
                            Delete
                        </Button>}
                    </Col>
                </Row>
            </div>
        </Form>
    )
}

export default UserForm;