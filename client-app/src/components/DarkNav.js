import { Navbar, NavbarBrand } from "reactstrap";

const DarkNav = () => {
    return (
        <Navbar
            className="my-2"
            color="dark"
            dark
        >
            <NavbarBrand href="/">
            <img
                alt="logo"
                src="https://p.kindpng.com/picc/s/146-1466911_apps-addressbook-icon-address-book-icon-ico-hd.png"
                style={{
                height: 40,
                width: 40
                }}
            />
            <span style={{marginLeft:'1em'}}>Simple Contact List</span>
            </NavbarBrand>
        </Navbar>
    )
}

export default DarkNav;