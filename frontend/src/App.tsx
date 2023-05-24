import { useState } from "react";
import "./App.css";
import debounce from "lodash.debounce";

export default function App() {
  const [query, setQuery] = useState("");

  const searchItems = debounce((searchValue: string) => {
    setQuery(searchValue);
  }, 500);

  return (
    <>
      <div className="relative flex items-centers justify-center">
        <input
          type="search"
          className="w-96 h-10 border-0 focus:ring-0 focus:outline-0 rounded-lg p-4 text-sm text-slate-200"
          // className="rounded border-0 "
          id="search"
          placeholder="Search"
          onChange={(e) => searchItems(e.target.value)}
        />
      </div>
      <h3>{query}</h3>
    </>
  );
}
