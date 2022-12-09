import React from "react";
import { Container } from "reactstrap";
import Navbar from '../components/DarkNav'

const Layout = ({children}) => {
    return (
        <>
            <Navbar />
            <Container style={{marginTop:'3em'}}>
                {children}
            </Container>
        </>
    )
}

export default Layout;