ROW_NUMBER() OVER(ORDER BY mc.idmodelcalc ASC)-1 AS Row#

ROW_NUMBER() OVER(PARTITION BY recovery_model_desc ORDER BY name ASC) 