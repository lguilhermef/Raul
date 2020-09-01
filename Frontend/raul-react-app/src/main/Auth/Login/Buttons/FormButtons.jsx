import React from 'react'
import './FormButtons.css'
import axios from 'axios'

const apiURL = "https://localhost:44384/api/auth/login";

const postLoginData = function postLoginData (props) {
  
    axios({
        method: 'post',
        url: apiURL,
        data: props.loginData
      }).then(resp => {
          if (resp.data.username != null) {
            props.login(resp.data)
          }
      })
}

export default props =>
    <div>
        <button className="cbutton" onClick={ () => postLoginData(props)}>Login</button>
       {/* <button className="cbutton" onClick={props.registerBtn}>Register</button> */}
    </div>