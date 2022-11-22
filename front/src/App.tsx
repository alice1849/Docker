import React, { useEffect, useState } from 'react';
import logo from './logo.svg';
import './App.css';
import { NamedTupleMember } from 'typescript';
import { Product } from './models/ProductModel';
import GetProductComponent from './components/GetProductComponent';
import PostProductComponent from './components/PostProductComponent';
import DeleteProductComponent from './components/DeleteProductComponent';
import PutProductComponent from './components/PutProductComponent';




const getProduct  = async (url:string): Promise<Product> => {
  
  const response = await fetch (url, {
    method: "GET",
    mode: 'cors'
  });
  const product = await response.json();

  return await product as Product ;

}

function App() {
  
  const [product1, setProduct1] = useState<Product | null>(null);

  useEffect(() => {
    const initialize = async () => {
      //debugger
      const loadedProduct1 = await getProduct('https://localhost:7123/Product/0');
      //console.log(loadedProduct1);
      setProduct1(loadedProduct1);
    }
    initialize();
  }, [])


 
  return (
    <>
    <div className="App">
     
     <GetProductComponent></GetProductComponent>
     <br></br>
     <PostProductComponent></PostProductComponent>
     <br></br>
     <DeleteProductComponent></DeleteProductComponent>
     <br></br>
     <PutProductComponent></PutProductComponent>
    </div>
    </>
  );
}

export default App;
