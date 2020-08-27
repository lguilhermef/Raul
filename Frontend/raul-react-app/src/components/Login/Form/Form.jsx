import React from 'react'
import 'Form.css'

const updateField = (event) => {
    const loginData = this.state.loginData;
    loginData[event.target.name] = event.target.value;
    this.setState({ loginData })
}

export default props => 

    <div>
        <h1>{this.state.title}</h1>
        <label>User</label>

        <input type="text" className="form-control"
        name="username" value={this.state.loginData.username}
        placeholder="Insert username..."
        onChange={e => updateField(e)}></input>

        <label>Password</label>
        <input type="text" className="form-control"
        name="password" value={this.state.loginData.password}
        placeholder="Insert password..."
        onChange={e => updateField(e)}></input>
    </div>