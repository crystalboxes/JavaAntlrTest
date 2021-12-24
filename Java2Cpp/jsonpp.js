const fs = require("fs");
const out = require("./bin/out.json");

const getChildren = (node) => {
  const name = node.VisitorName;
  const children = node.VisitorChildren.$values
    .map(getChildren)
    .filter((x) => x[""]?.length !== 0);
  const result = { [name]: children.length === 1 ? children[0] : children };

  if (result[name]?.length === 0 && name !== "") {
    result[name] = node.VisitorContextText;
  }
  return result;
};

fs.writeFileSync("bin/outpp.json", JSON.stringify(getChildren(out)));
