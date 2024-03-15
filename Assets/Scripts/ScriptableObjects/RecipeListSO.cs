using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// We commented this because we only wanted to create one ever. Couldn't we create it by code?
//[CreateAssetMenu()]
public class RecipeListSO : ScriptableObject {
    public List<RecipeSO> recipeSOList;
}
