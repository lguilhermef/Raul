import React from 'react'
import './Form.css'

export default props => 
    <div>
        
        <label>User</label>

        <input type="text" className="form-control"
        name="username" value={props.username}
        placeholder="Insert username..."
        onChange={e => props.updateField(e)}></input>

        <label>Password</label>
        <input type="password" className="form-control"
        name="password" value={props.password}
        placeholder="Insert password..."
        onChange={e => props.updateField(e)}></input>
    </div>