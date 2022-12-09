import 'bootstrap/dist/css/bootstrap.min.css';
import UserList from './pages/UserList';
import React from 'react'
import {BrowserRouter as Router, Route, Routes} from 'react-router-dom';
import NotFound from './pages/NotFound';
import './App.css';
import AddUser from './pages/AddUser';
import EditUser from './pages/EditUser';
import Layout from './pages/Layout';

function App() {
    return (
      <div className='App'>
        <Layout>
          <Routes>
            <Route exact path="/" element={<UserList/>}/>
            <Route exact path="/user/add" element={<AddUser/>}/>
            <Route exact path="/user/edit/:id" element={<EditUser/>}/>
            <Route path="*" element={<NotFound/>}/>
          </Routes>
        </Layout>
      </div>
    );
}

export default App;
