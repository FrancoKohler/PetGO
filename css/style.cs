/* Error: Can't find stylesheet to import.
 *    ,
 * 12 | @import "utilities/mixin";
 *    |         ^^^^^^^^^^^^^^^^^
 *    '
 *   scss\style.scss 12:9  root stylesheet */

body::before {
  font-family: "Source Code Pro", "SF Mono", Monaco, Inconsolata, "Fira Mono",
      "Droid Sans Mono", monospace, monospace;
  white-space: pre;
  display: block;
  padding: 1em;
  margin-bottom: 1em;
  border-bottom: 2px solid black;
  content: "Error: Can't find stylesheet to import.\a    \2577 \a 12 \2502  @import \"utilities/mixin\";\d\a    \2502          ^^^^^^^^^^^^^^^^^\a    \2575 \a   scss\\style.scss 12:9  root stylesheet";
}
