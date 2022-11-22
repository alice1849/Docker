import { useState } from "react";
import Button from 'react-bootstrap/Button';
import Form from 'react-bootstrap/Form';
import ProductComponent from "./ProductComponent";

const DeleteProductComponent = () => {

    const [productId, setId] = useState("");
    const [result, setResult] = useState<boolean | false>(false);
    

    const getProduct  = async () => {
        //debugger
        console.log(productId);
        const url = "https://localhost:7123/Product/" + productId;
        console.log(url);
  
        const response = await fetch (url, {
          method: "DELETE",
          mode: 'cors'
        });
        
        const result = await response.json();
        //debugger
        console.log(result);
        setResult(result);
       
      
      }
      const res = result ? <div>You deleted product number  {productId}</div> :
       <div>Something went wrong</div>

      

    return(
        <div>
        <legend>Delete product by id</legend>
        <p>
          <label>id:
              <input type='text' value={productId} onChange={(e) => setId(e.target.value)}></input>
              <button onClick={() => getProduct()}>DELETE</button>
              
          </label>
          <br></br>
          { res}
        </p>
        </div>

        
    );
}
export default DeleteProductComponent